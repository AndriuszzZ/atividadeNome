namespace Views {

    public class Nome {
        public static void Show() {
            Form form = new Form();
            form.Width = 300;
            form.Height = 200;

            Label label = new Label();
            label.Text = "Olá! Por favor, digite seu nome:";
            label.Location = new Point(90, 10);
            label.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(90, 30);
            textBox.Width = 100;

            Button helloButton = new Button();
            helloButton.Text = "Confirmar";
            helloButton.Location = new Point(90, 55);
            helloButton.Width = 100;
            helloButton.Height = 30;
            helloButton.Click += (sender, e) => {
                Form helloForm = new Form();
                helloForm.Width = 300;
                helloForm.Height = 200;

                Label helloLabel = new Label();
                helloLabel.Text = "Olá, " + textBox.Text;
                helloLabel.Location = new Point(110, 25);
                helloLabel.AutoSize = true;
                helloLabel.Width = 100;
                helloLabel.Height = 30;

                Button okButton = new Button();
                okButton.Text = "OK";
                okButton.Location = new Point(90, 50);
                okButton.Width = 100;
                okButton.Height = 30;
                okButton.Click += (sender, e) => {
                    helloForm.Close();
                };

                helloForm.Controls.Add(okButton);
                helloForm.Controls.Add(helloLabel);
                helloForm.ShowDialog();

            };

            Button closeButton = new Button();
            closeButton.Text = "Fechar";
            closeButton.Location = new Point(90, 90);
            closeButton.Width = 100;
            closeButton.Height = 30;
            closeButton.Click += (sender, e) => {
                form.Close();
            };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(helloButton);
            form.Controls.Add(closeButton);
            form.ShowDialog();


        }
    }
}