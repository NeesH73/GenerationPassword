using GenerationPassword;
using NUnit.Framework;
using System.IO;

[TestFixture]
public class UnitTest1
{
    [Test]
    public void TestExitButton_ExitApplicationIfYes()
    {
        Form1 form = new Form1();
        var result = form.btnexit_Click(this, null);
        Assert.AreEqual(DialogResult.Yes, result);
    }

    [Test]
    public void TestExitButton_ShowFormIfNo()
    {
        Form1 form = new Form1();
        var result = form.btnexit_Click(this, null);
        Assert.AreEqual(DialogResult.No, result);
    }

    [Test]
    public void TestGeneratePassword_ReturnsPasswordWithExpectedLength()
    {
        Form1 form = new Form1();
        var password = form.GeneratePassword(8, true, true);
        Assert.AreEqual(8, password.Length);
    }

    [Test]
    public void TestGeneratePassword_ExcludesSimilarCharacters()
    {
        Form1 form = new Form1();
        var password = form.GeneratePassword(8, false, true);
        Assert.IsFalse(password.Contains("i") || password.Contains("l") || password.Contains("I") || password.Contains("L"));
    }

    [Test]
    public void TestGeneratePassword_ExcludesSpecialCharacters()
    {
        Form1 form = new Form1();
        var password = form.GeneratePassword(8, true, false);
        Assert.IsFalse(password.Contains("{") || password.Contains("}"));
    }

    [Test]
    public void TestSaveButton_SavesLoginAndPasswordToFile()
    {
        Form1 form = new Form1();
        form.textBoxLogin.Text = "testuser";
        form.textBoxPass.Text = "testpassword";

        form.btnsaved_Click(this, null);

        string filePath = "passwords.txt";
        string[] lines = File.ReadAllLines(filePath);
        Assert.IsTrue(lines.Length > 0 && lines[lines.Length - 1] == "Логин: testuser, Пароль: testpassword");
    }

}
