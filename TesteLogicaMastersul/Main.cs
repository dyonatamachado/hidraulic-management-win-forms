using TesteLogicaMastersul.Entities;

namespace TesteLogicaMastersul
{
    public partial class Main : Form
    {
        private readonly Valve _valve = new Valve();
        private readonly Pump _pump = new Pump();

        public Main()
        {
            InitializeComponent();
        }

        private void ManageValve(int sensor1, int sensor2)
        {
            if(_valve.IsOpen && sensor1 == 1)
            {
                _valve.Close();
                valvula1Value.Text = "Fechada";
            }

            if(!_valve.IsOpen && sensor2 == 0)
            {
                _valve.Open();
                valvula1Value.Text = "Aberta";
            }
        }

        private void ManagePump(int sensor2, int sensor3, int sensor4)
        {
            if(_pump.IsOn && (sensor2 == 0 || sensor3 == 1))
            {
                _pump.TurnOff();
                bomba1Value.Text = "Desligada";
            }

            if (!_pump.IsOn && sensor2 == 1 && sensor4 == 0)
            {
                _pump.TurnOn();
                bomba1Value.Text = "Ligada";
            }
        }

        private void ChangeSendBtnState()
        {
            var formHasNullOrWhiteSpaceInput = string.IsNullOrWhiteSpace(sensor1Input.Text) ||
                string.IsNullOrWhiteSpace(sensor2Input.Text) ||
                string.IsNullOrWhiteSpace(sensor3Input.Text) ||
                string.IsNullOrWhiteSpace(sensor4Input.Text);

            if (formHasNullOrWhiteSpaceInput) sendBtn.Enabled = false;
            else sendBtn.Enabled = true;
        }

        private void ResetForm()
        {
            this.sensor1Input.Text = null;
            this.sensor2Input.Text = null;
            this.sensor3Input.Text = null;
            this.sensor4Input.Text = null;
            this.sendBtn.Enabled = false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var sensor1 = Convert.ToInt32(this.sensor1Input.Text);
            var sensor2 = Convert.ToInt32(this.sensor2Input.Text);
            var sensor3 = Convert.ToInt32(this.sensor3Input.Text);
            var sensor4 = Convert.ToInt32(this.sensor4Input.Text);

            if((sensor1 == 1 && sensor2 == 0) || (sensor3 == 1 && sensor4 == 0))
            {
                MessageBox.Show("Os dados de leitura fornecidos estão inválidos. Confirme os valores e/ou configure novamente os sensores.",
                    "Dados inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetForm();
                return;
            }

            this.ManageValve(sensor1, sensor2);
            this.ManagePump(sensor2, sensor3, sensor4);

            ResetForm();
            return;
        }

        private void HandleWithInvalidCharacters(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar != '0' && e.KeyChar != '1') || (this.sensor4Input.Text.Length == 1))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void sensor1Input_KeyPress(object sender, KeyPressEventArgs e) => HandleWithInvalidCharacters(e);

        private void sensor2Input_KeyPress(object sender, KeyPressEventArgs e) => HandleWithInvalidCharacters(e);

        private void sensor3Input_KeyPress(object sender, KeyPressEventArgs e) => HandleWithInvalidCharacters(e);

        private void sensor4Input_KeyPress(object sender, KeyPressEventArgs e) => HandleWithInvalidCharacters(e);

        private void sensor1Input_TextChanged(object sender, EventArgs e) => ChangeSendBtnState();

        private void sensor2Input_TextChanged(object sender, EventArgs e) => ChangeSendBtnState();

        private void sensor3Input_TextChanged(object sender, EventArgs e) => ChangeSendBtnState();

        private void sensor4Input_TextChanged(object sender, EventArgs e) => ChangeSendBtnState();
    }
}