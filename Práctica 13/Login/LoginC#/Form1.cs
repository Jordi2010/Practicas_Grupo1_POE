using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace LoginC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.RoyalBlue;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Creamos la variable de nuestro email e inicializamos nuestro MimeMessage
            var mensaje = new MimeMessage();

            //Creamos la dirección del correo del emisor
            mensaje.From.Add(new MailboxAddress("Jordi Amaya", "jordi@example.com"));

            //Creamos la dirección del correo del receptor
            mensaje.To.Add(new MailboxAddress("Haziel Martínez", "hazielmar@example.com"));

            //Creamos el motivo de nuestro correo
            mensaje.Subject = "Recuperar contraseña";

            //Creamos el cuerpo de nuestro correo donde irá nuestro contenido
            mensaje.Body = new TextPart("plain")
            {
                //Contenido
                Text = "Hola, este es un link para que puedas restaurar tu contraseña"
            };

            //Credenciales para la conexión entre MailTrap, la librería MailKit y VisualStudio

            //Vamos a ocupar el using MailKit.Net.Smtp;
            using (var cliente = new SmtpClient())
            {
                //Creamos la conexión con los parametros como la url y puerto
                cliente.Connect("sandbox.smtp.mailtrap.io", 2525);

                //Tenemos que auntenticarnos con nuestro usuario y contraseña del MailTrap
                cliente.Authenticate("fc92ef6a721743", "09ff1c21417628");

                //Instanciamos el mensaje que habíamos creado arriba
                cliente.Send(mensaje);

                //Desconectamos el servicio, una vez enviado el mensaje
                cliente.Disconnect(true);

                MessageBox.Show("Tu correo ha sido enviado");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Instanciar el formulario nuevo
            VistaLogin2 vistaNueva = new VistaLogin2();

            //Indicarle el nuevo formulario de donde viene su instancia
            AddOwnedForm(vistaNueva);

            //Se accede al control deseado
            vistaNueva.Show();

            //Minimizamos la ventana anterior
            this.Hide();
        }
    }
}