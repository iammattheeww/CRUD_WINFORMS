using CRUD_FORMS;
using System.Security.Policy;



static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        AppContext appContext = new AppContext();
        Application.Run(appContext);
    }

}



// Custom ApplicationContext
public class AppContext : ApplicationContext
{
    public AppContext()
    {
        // Start with dash
        MainForm dashForm = new MainForm();
        dashForm.LoginSucceeded += OnLoginSucceeded; // raise this event from dash or FrmLogin
        dashForm.FormClosed += (s, e) => ExitThread(); // fallback exit
        dashForm.Show();
    }

    private void OnLoginSucceeded(string username)
    {
        maindash mainDash = new maindash(username);
        mainDash.FormClosed += (s, e) => ExitThread(); // exit when dashboard closes
        mainDash.Show();
    }

}