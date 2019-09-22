namespace Izjednacenje2D
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslVrstaIzjednacenja = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSigmaKvadrat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSigma = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSo2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssln = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssld = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslf = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslGlobalniTest = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbLokalniBeta = new System.Windows.Forms.TextBox();
            this.tbLokalniAlfa = new System.Windows.Forms.TextBox();
            this.lblLokalniBeta = new System.Windows.Forms.Label();
            this.lblLokalniAlfa = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbGlobalniAlfa = new System.Windows.Forms.TextBox();
            this.lblGlobalniAlfa = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnIzjednaci = new System.Windows.Forms.Button();
            this.btnFormirajMatrice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbBazniVektor = new System.Windows.Forms.CheckBox();
            this.ckbDuzina = new System.Windows.Forms.CheckBox();
            this.ckbKut = new System.Windows.Forms.CheckBox();
            this.ckbPravac = new System.Windows.Forms.CheckBox();
            this.ckbAzimut = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSigmaNulaKvadrat = new System.Windows.Forms.TextBox();
            this.tbSigmaNula = new System.Windows.Forms.TextBox();
            this.lblSigmaNulaKvadrat = new System.Windows.Forms.Label();
            this.lblSigmaNula = new System.Windows.Forms.Label();
            this.gbVrstaIzjednacenja = new System.Windows.Forms.GroupBox();
            this.rbIzjednacenjePrisila = new System.Windows.Forms.RadioButton();
            this.rbKlasicanNacin = new System.Windows.Forms.RadioButton();
            this.rbParcijalniMinimalniTrag = new System.Windows.Forms.RadioButton();
            this.rbMinimalniTrag = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpTocke = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbKlasicanNacin = new System.Windows.Forms.GroupBox();
            this.ckbKlasicanKoordinata = new System.Windows.Forms.CheckBox();
            this.ckbKlasicanBazniVektor = new System.Windows.Forms.CheckBox();
            this.ckbKlasicanDuzina = new System.Windows.Forms.CheckBox();
            this.ckbKlasicanAzimut = new System.Windows.Forms.CheckBox();
            this.gbKlasicanMjerilo = new System.Windows.Forms.GroupBox();
            this.lblKlasicanMvizura = new System.Windows.Forms.Label();
            this.cmbKlasicanMvizura = new System.Windows.Forms.ComboBox();
            this.lblKlasicanMstajaliste = new System.Windows.Forms.Label();
            this.cmbKlasicanMstajaliste = new System.Windows.Forms.ComboBox();
            this.gbKlasicanRotacija = new System.Windows.Forms.GroupBox();
            this.lblKlasicanRvizura = new System.Windows.Forms.Label();
            this.lblKlasicanRstajaliste = new System.Windows.Forms.Label();
            this.cmbKlasicanRvizura = new System.Windows.Forms.ComboBox();
            this.cmbKlasicanRstajaliste = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbKlasicanX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKlasicanY = new System.Windows.Forms.ComboBox();
            this.gb2Dkoordinate = new System.Windows.Forms.GroupBox();
            this.btnDodajTocku = new System.Windows.Forms.Button();
            this.lbl2Dx = new System.Windows.Forms.Label();
            this.lbl2Dy = new System.Windows.Forms.Label();
            this.lbl2Dtocka = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbTocka = new System.Windows.Forms.TextBox();
            this.lvTocka = new System.Windows.Forms.ListView();
            this.tocka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvX = new System.Windows.Forms.ListView();
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvY = new System.Windows.Forms.ListView();
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAzimut = new System.Windows.Forms.TabPage();
            this.pnlAzimut = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rtbAzimuti2dOpis = new System.Windows.Forms.RichTextBox();
            this.gb2dMjerenjeAzimuti = new System.Windows.Forms.GroupBox();
            this.lbl2dAzimutiTolerancija = new System.Windows.Forms.Label();
            this.tb2dAzimutiTolarancija = new System.Windows.Forms.TextBox();
            this.gb2dAzimutiTezine = new System.Windows.Forms.GroupBox();
            this.rb2dAzimutiBrojTocaka = new System.Windows.Forms.RadioButton();
            this.tb2dAzimutBrojTocaka = new System.Windows.Forms.TextBox();
            this.lbl2dAzimutSigmaSekunde = new System.Windows.Forms.Label();
            this.tb2dAzimutTezina = new System.Windows.Forms.TextBox();
            this.tb2dAzimutSigma = new System.Windows.Forms.TextBox();
            this.rb2dAzimutiTezina = new System.Windows.Forms.RadioButton();
            this.rb2dAzimutiSigma = new System.Windows.Forms.RadioButton();
            this.btn2dDodajAzimut = new System.Windows.Forms.Button();
            this.lbl2dAzimutiSekunde = new System.Windows.Forms.Label();
            this.lbl2dAzimutiMinute = new System.Windows.Forms.Label();
            this.lbl2dAzimutiStupnjevi = new System.Windows.Forms.Label();
            this.tb2dAzimutiSekunde = new System.Windows.Forms.TextBox();
            this.tb2dAzimutiMinute = new System.Windows.Forms.TextBox();
            this.tb2dAzimutiStupnjevi = new System.Windows.Forms.TextBox();
            this.cmb2dAzimutiVizura = new System.Windows.Forms.ComboBox();
            this.lbl2dAzimutiMjerenje = new System.Windows.Forms.Label();
            this.cmb2DazimutiStajaliste = new System.Windows.Forms.ComboBox();
            this.lbl2dAzimutiVizura = new System.Windows.Forms.Label();
            this.lbl2dAzimutiStajaliste = new System.Windows.Forms.Label();
            this.gb2dAzimutiMjerenja = new System.Windows.Forms.GroupBox();
            this.lvAzimut = new System.Windows.Forms.ListView();
            this.AzimutKontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutStajaliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutVizura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutMjerene = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutKoordinate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutiTezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutSigma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutStDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutStDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutVzDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AzimutVzDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpPravac = new System.Windows.Forms.TabPage();
            this.pnlPravac = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.rtbPravci2dOpis = new System.Windows.Forms.RichTextBox();
            this.gb2dMjerenjePravci = new System.Windows.Forms.GroupBox();
            this.lbl2dPravciTolerancija = new System.Windows.Forms.Label();
            this.tb2dPravciTolarancijaZ = new System.Windows.Forms.TextBox();
            this.gb2dPravciTezine = new System.Windows.Forms.GroupBox();
            this.lbl2dPravciSigmaBrojGirusa = new System.Windows.Forms.Label();
            this.tb2dPravciSigmaBrojGirusa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2dPravciTezina = new System.Windows.Forms.TextBox();
            this.tb2dPravciSigma = new System.Windows.Forms.TextBox();
            this.rb2dPravciTezina = new System.Windows.Forms.RadioButton();
            this.rb2dPravciSigma = new System.Windows.Forms.RadioButton();
            this.btn2dDodajPravac = new System.Windows.Forms.Button();
            this.lbl2dPravciSekunde = new System.Windows.Forms.Label();
            this.lbl2dPravciMinute = new System.Windows.Forms.Label();
            this.lbl2dPravciST = new System.Windows.Forms.Label();
            this.tb2dPravciSekunde = new System.Windows.Forms.TextBox();
            this.tb2dPravciMinute = new System.Windows.Forms.TextBox();
            this.tb2dPravciStupnjevi = new System.Windows.Forms.TextBox();
            this.cmb2dPravciVizura = new System.Windows.Forms.ComboBox();
            this.lbl2dPravciMjerenje = new System.Windows.Forms.Label();
            this.cmb2DpravciStajaliste = new System.Windows.Forms.ComboBox();
            this.lbl2dPravciVizura = new System.Windows.Forms.Label();
            this.lbl2dPravciStajaliste = new System.Windows.Forms.Label();
            this.gb2dPravciMjerenja = new System.Windows.Forms.GroupBox();
            this.lvPravac = new System.Windows.Forms.ListView();
            this.PravciZkontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciStajaliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciVizura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciMjerenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciSmjerni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciZsrednje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciTezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciSigma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciStajalisteDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciStajalisteDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciVizuraDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PravciVizuraDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpKut = new System.Windows.Forms.TabPage();
            this.pnlKut = new System.Windows.Forms.Panel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.rtbKutOpis = new System.Windows.Forms.RichTextBox();
            this.gb2dKuteviMjerenje = new System.Windows.Forms.GroupBox();
            this.cmb2DkuteviDO = new System.Windows.Forms.ComboBox();
            this.lbl2dKuteviDo = new System.Windows.Forms.Label();
            this.lbl2dKuteviTolerancija = new System.Windows.Forms.Label();
            this.tb2dKuteviTolerancija = new System.Windows.Forms.TextBox();
            this.gb2dKuteviTezina = new System.Windows.Forms.GroupBox();
            this.tbKutTezina = new System.Windows.Forms.TextBox();
            this.lbl2dKuteviSigmaBrojGirusa = new System.Windows.Forms.Label();
            this.tbKutSigmaBrojGirusa = new System.Windows.Forms.TextBox();
            this.lbl2dKuteviSigmaKutaSekunde = new System.Windows.Forms.Label();
            this.tb2dKuteviSigmaKut = new System.Windows.Forms.TextBox();
            this.rb2dKuteviSigmaKuta = new System.Windows.Forms.RadioButton();
            this.lblKuteviSigmaPravacSekunde = new System.Windows.Forms.Label();
            this.tb2dKuteviSigmaPravac = new System.Windows.Forms.TextBox();
            this.rb2dKuteviTezina = new System.Windows.Forms.RadioButton();
            this.rb2dKuteviSigmaPravac = new System.Windows.Forms.RadioButton();
            this.btn2dKuteviDodaj = new System.Windows.Forms.Button();
            this.lbl2dKuteviMjerenjeSekunde = new System.Windows.Forms.Label();
            this.lbl2dKuteviMjerenjeMinute = new System.Windows.Forms.Label();
            this.lbl2dKuteviMjerenjeStupnjevi = new System.Windows.Forms.Label();
            this.tb2dKuteviSekunde = new System.Windows.Forms.TextBox();
            this.tb2dKuteviMinute = new System.Windows.Forms.TextBox();
            this.tb2dKuteviStupnjevi = new System.Windows.Forms.TextBox();
            this.cmb2DkuteviOD = new System.Windows.Forms.ComboBox();
            this.lbl2dKuteviMjerenje = new System.Windows.Forms.Label();
            this.cmb2DkuteviStajaliste = new System.Windows.Forms.ComboBox();
            this.lbl2dKuteviOd = new System.Windows.Forms.Label();
            this.lbl2dKuteviStajaliste = new System.Windows.Forms.Label();
            this.gb2dKuteviMjerenja = new System.Windows.Forms.GroupBox();
            this.lvKut = new System.Windows.Forms.ListView();
            this.KuteviKontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviStajaliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviDO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviMjerenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviKoordinate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviTezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviSigmaKuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviStajalisteDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviStajalisteDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviOdDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviOdDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviDoDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KuteviDoDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDuzina = new System.Windows.Forms.TabPage();
            this.pnlDuzina = new System.Windows.Forms.Panel();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.rtbDuzineOpis = new System.Windows.Forms.RichTextBox();
            this.gb2dMjerenjeDuzine = new System.Windows.Forms.GroupBox();
            this.lbl2dDuzineTolerancija = new System.Windows.Forms.Label();
            this.tb2dDuzineTolarancija = new System.Windows.Forms.TextBox();
            this.gb2dDuzineTezine = new System.Windows.Forms.GroupBox();
            this.lbl2dDuzineSigmaBrojPonavljanja = new System.Windows.Forms.Label();
            this.tb2dDuzineSigmaBrojPonavljanja = new System.Windows.Forms.TextBox();
            this.lbl2dDuzineSigmaPpm = new System.Windows.Forms.Label();
            this.lbl2dDuzineSigmaMm = new System.Windows.Forms.Label();
            this.tb2dDuzineTezina = new System.Windows.Forms.TextBox();
            this.tb2dDuzineSigmaMm = new System.Windows.Forms.TextBox();
            this.tb2dDuzineSigmaPpm = new System.Windows.Forms.TextBox();
            this.rb2dDuzineTezina = new System.Windows.Forms.RadioButton();
            this.rb2dDuzineSigma = new System.Windows.Forms.RadioButton();
            this.btn2dDodajDuzinu = new System.Windows.Forms.Button();
            this.lbl2dDuzinem = new System.Windows.Forms.Label();
            this.tb2dDuzineMjerenje = new System.Windows.Forms.TextBox();
            this.cmb2dDuzineVizura = new System.Windows.Forms.ComboBox();
            this.lbl2dDuzineMjerenje = new System.Windows.Forms.Label();
            this.cmb2DduzineStajaliste = new System.Windows.Forms.ComboBox();
            this.lbl2dDuzineVizura = new System.Windows.Forms.Label();
            this.lbl2dDuzineStajaliste = new System.Windows.Forms.Label();
            this.gb2dDuzineMjerenja = new System.Windows.Forms.GroupBox();
            this.lvDuzina = new System.Windows.Forms.ListView();
            this.DuzineKontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineStajaliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineVizura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineMjerenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineKoordinate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineTezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineSigma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineStajalisteDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineStajalisteDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineVizuraDerivacijaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuzineVizuraDerivacijaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpBazniVektor = new System.Windows.Forms.TabPage();
            this.pnlBazniVektor = new System.Windows.Forms.Panel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.rtbBazniVektoriOpis = new System.Windows.Forms.RichTextBox();
            this.gb2dMjerenjeBazni = new System.Windows.Forms.GroupBox();
            this.lbl2dBazniXm = new System.Windows.Forms.Label();
            this.tb2dBazniMjerenjeX = new System.Windows.Forms.TextBox();
            this.lbl2dBazniMjerenjeX = new System.Windows.Forms.Label();
            this.lbl2dBazniTolerancija = new System.Windows.Forms.Label();
            this.tb2dBazniTolarancija = new System.Windows.Forms.TextBox();
            this.gb2dBazniTezine = new System.Windows.Forms.GroupBox();
            this.lbl2dBazniTezinaX = new System.Windows.Forms.Label();
            this.tb2dBazniTezinaX = new System.Windows.Forms.TextBox();
            this.lbl2dBazniTezinaYX = new System.Windows.Forms.Label();
            this.tb2dBazniTezinaYX = new System.Windows.Forms.TextBox();
            this.lbl2dBazniTezinaY = new System.Windows.Forms.Label();
            this.tb2dBazniTezinaY = new System.Windows.Forms.TextBox();
            this.lbl2dBazniSigmaX2 = new System.Windows.Forms.Label();
            this.tb2dBazniSigmaX2 = new System.Windows.Forms.TextBox();
            this.lbl2dBazniSigmaYX = new System.Windows.Forms.Label();
            this.tb2dBazniSigmaYX = new System.Windows.Forms.TextBox();
            this.lbl2dBazniSigmaY2 = new System.Windows.Forms.Label();
            this.tb2dBazniSigmaY2 = new System.Windows.Forms.TextBox();
            this.rb2dBazniTezina = new System.Windows.Forms.RadioButton();
            this.rb2dBazniSigma = new System.Windows.Forms.RadioButton();
            this.btn2dDodajBazniVektor = new System.Windows.Forms.Button();
            this.lbl2dBazniYm = new System.Windows.Forms.Label();
            this.tb2dBazniMjerenjeY = new System.Windows.Forms.TextBox();
            this.cmb2dBazniVizura = new System.Windows.Forms.ComboBox();
            this.lbl2dBazniMjerenjeY = new System.Windows.Forms.Label();
            this.cmb2DbazniStajaliste = new System.Windows.Forms.ComboBox();
            this.lbl2dBazniVizura = new System.Windows.Forms.Label();
            this.lbl2dBazniStajaliste = new System.Windows.Forms.Label();
            this.lvBazniVektor = new System.Windows.Forms.ListView();
            this.BazniKontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniStajaliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniVizura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniYmjereno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniYkoordinate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniYf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniXmjereno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniXkoordinate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniXf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniTezinaY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniTezinaYX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniTezinaX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniSigmaY2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniSigmaYX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BazniSigmaX2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpA = new System.Windows.Forms.TabPage();
            this.lvA = new System.Windows.Forms.ListView();
            this.tpP = new System.Windows.Forms.TabPage();
            this.lvP = new System.Windows.Forms.ListView();
            this.tpF = new System.Windows.Forms.TabPage();
            this.lvF = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpG = new System.Windows.Forms.TabPage();
            this.lvG = new System.Windows.Forms.ListView();
            this.tpIzjednacenje = new System.Windows.Forms.TabPage();
            this.tcIzjednacenje = new System.Windows.Forms.TabControl();
            this.OcjenaFunkcija = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvOcjenaFunkcija = new System.Windows.Forms.ListView();
            this.funkcija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocjeniva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.var = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzjednaceneVelicine = new System.Windows.Forms.TabPage();
            this.tcIzjednaceneVrijednosti = new System.Windows.Forms.TabControl();
            this.tpMjerenja = new System.Windows.Forms.TabPage();
            this.lvIzjednacenaMjerenja = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpIzjednaceneKoordinate = new System.Windows.Forms.TabPage();
            this.lvIzjednaceneKoordinate = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpElipse = new System.Windows.Forms.TabPage();
            this.lvElipsa = new System.Windows.Forms.ListView();
            this.tpRelativneElipse = new System.Windows.Forms.TabPage();
            this.lvElipsaRelativna = new System.Windows.Forms.ListView();
            this.tpStatistika = new System.Windows.Forms.TabPage();
            this.lvStatistika = new System.Windows.Forms.ListView();
            this.tpTestPouzdanostiFigure = new System.Windows.Forms.TabPage();
            this.lvTestPouzdanosti = new System.Windows.Forms.ListView();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbVrstaIzjednacenja.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpTocke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbKlasicanNacin.SuspendLayout();
            this.gbKlasicanMjerilo.SuspendLayout();
            this.gbKlasicanRotacija.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb2Dkoordinate.SuspendLayout();
            this.tpAzimut.SuspendLayout();
            this.pnlAzimut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gb2dMjerenjeAzimuti.SuspendLayout();
            this.gb2dAzimutiTezine.SuspendLayout();
            this.gb2dAzimutiMjerenja.SuspendLayout();
            this.tpPravac.SuspendLayout();
            this.pnlPravac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gb2dMjerenjePravci.SuspendLayout();
            this.gb2dPravciTezine.SuspendLayout();
            this.gb2dPravciMjerenja.SuspendLayout();
            this.tpKut.SuspendLayout();
            this.pnlKut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.gb2dKuteviMjerenje.SuspendLayout();
            this.gb2dKuteviTezina.SuspendLayout();
            this.gb2dKuteviMjerenja.SuspendLayout();
            this.tpDuzina.SuspendLayout();
            this.pnlDuzina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.gb2dMjerenjeDuzine.SuspendLayout();
            this.gb2dDuzineTezine.SuspendLayout();
            this.gb2dDuzineMjerenja.SuspendLayout();
            this.tpBazniVektor.SuspendLayout();
            this.pnlBazniVektor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.gb2dMjerenjeBazni.SuspendLayout();
            this.gb2dBazniTezine.SuspendLayout();
            this.tpA.SuspendLayout();
            this.tpP.SuspendLayout();
            this.tpF.SuspendLayout();
            this.tpG.SuspendLayout();
            this.tpIzjednacenje.SuspendLayout();
            this.OcjenaFunkcija.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.IzjednaceneVelicine.SuspendLayout();
            this.tcIzjednaceneVrijednosti.SuspendLayout();
            this.tpMjerenja.SuspendLayout();
            this.tpIzjednaceneKoordinate.SuspendLayout();
            this.tpElipse.SuspendLayout();
            this.tpRelativneElipse.SuspendLayout();
            this.tpStatistika.SuspendLayout();
            this.tpTestPouzdanostiFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVrstaIzjednacenja,
            this.tsslSigmaKvadrat,
            this.tsslSigma,
            this.tsslSo2,
            this.tsslSo,
            this.tssln,
            this.tsslu,
            this.tssld,
            this.tsslf,
            this.tsslGlobalniTest});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslVrstaIzjednacenja
            // 
            this.tsslVrstaIzjednacenja.Name = "tsslVrstaIzjednacenja";
            this.tsslVrstaIzjednacenja.Size = new System.Drawing.Size(101, 17);
            this.tsslVrstaIzjednacenja.Text = "Vrsta izjednacenja";
            // 
            // tsslSigmaKvadrat
            // 
            this.tsslSigmaKvadrat.Name = "tsslSigmaKvadrat";
            this.tsslSigmaKvadrat.Size = new System.Drawing.Size(80, 17);
            this.tsslSigmaKvadrat.Text = "SigmaKvadrat";
            // 
            // tsslSigma
            // 
            this.tsslSigma.Name = "tsslSigma";
            this.tsslSigma.Size = new System.Drawing.Size(39, 17);
            this.tsslSigma.Text = "sigma";
            // 
            // tsslSo2
            // 
            this.tsslSo2.Name = "tsslSo2";
            this.tsslSo2.Size = new System.Drawing.Size(26, 17);
            this.tsslSo2.Text = "So2";
            // 
            // tsslSo
            // 
            this.tsslSo.Name = "tsslSo";
            this.tsslSo.Size = new System.Drawing.Size(20, 17);
            this.tsslSo.Text = "So";
            // 
            // tssln
            // 
            this.tssln.Name = "tssln";
            this.tssln.Size = new System.Drawing.Size(14, 17);
            this.tssln.Text = "n";
            // 
            // tsslu
            // 
            this.tsslu.Name = "tsslu";
            this.tsslu.Size = new System.Drawing.Size(14, 17);
            this.tsslu.Text = "u";
            // 
            // tssld
            // 
            this.tssld.Name = "tssld";
            this.tssld.Size = new System.Drawing.Size(14, 17);
            this.tssld.Text = "d";
            // 
            // tsslf
            // 
            this.tsslf.Name = "tsslf";
            this.tsslf.Size = new System.Drawing.Size(11, 17);
            this.tsslf.Text = "f";
            // 
            // tsslGlobalniTest
            // 
            this.tsslGlobalniTest.Name = "tsslGlobalniTest";
            this.tsslGlobalniTest.Size = new System.Drawing.Size(73, 17);
            this.tsslGlobalniTest.Text = "Globalni test";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.gbVrstaIzjednacenja);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(884, 516);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.tbLokalniBeta);
            this.groupBox8.Controls.Add(this.tbLokalniAlfa);
            this.groupBox8.Controls.Add(this.lblLokalniBeta);
            this.groupBox8.Controls.Add(this.lblLokalniAlfa);
            this.groupBox8.Location = new System.Drawing.Point(8, 378);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 48);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lokalni test";
            // 
            // tbLokalniBeta
            // 
            this.tbLokalniBeta.Location = new System.Drawing.Point(109, 19);
            this.tbLokalniBeta.Name = "tbLokalniBeta";
            this.tbLokalniBeta.Size = new System.Drawing.Size(33, 20);
            this.tbLokalniBeta.TabIndex = 2;
            this.tbLokalniBeta.Text = "80";
            // 
            // tbLokalniAlfa
            // 
            this.tbLokalniAlfa.Location = new System.Drawing.Point(47, 19);
            this.tbLokalniAlfa.Name = "tbLokalniAlfa";
            this.tbLokalniAlfa.Size = new System.Drawing.Size(33, 20);
            this.tbLokalniAlfa.TabIndex = 0;
            this.tbLokalniAlfa.Text = "5";
            // 
            // lblLokalniBeta
            // 
            this.lblLokalniBeta.AutoSize = true;
            this.lblLokalniBeta.Location = new System.Drawing.Point(87, 22);
            this.lblLokalniBeta.Name = "lblLokalniBeta";
            this.lblLokalniBeta.Size = new System.Drawing.Size(16, 13);
            this.lblLokalniBeta.TabIndex = 1;
            this.lblLokalniBeta.Text = "b:";
            // 
            // lblLokalniAlfa
            // 
            this.lblLokalniAlfa.AutoSize = true;
            this.lblLokalniAlfa.Location = new System.Drawing.Point(25, 22);
            this.lblLokalniAlfa.Name = "lblLokalniAlfa";
            this.lblLokalniAlfa.Size = new System.Drawing.Size(16, 13);
            this.lblLokalniAlfa.TabIndex = 0;
            this.lblLokalniAlfa.Text = "a:";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.tbGlobalniAlfa);
            this.groupBox9.Controls.Add(this.lblGlobalniAlfa);
            this.groupBox9.Location = new System.Drawing.Point(8, 324);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(163, 48);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Globalni test";
            // 
            // tbGlobalniAlfa
            // 
            this.tbGlobalniAlfa.Location = new System.Drawing.Point(50, 19);
            this.tbGlobalniAlfa.Name = "tbGlobalniAlfa";
            this.tbGlobalniAlfa.Size = new System.Drawing.Size(53, 20);
            this.tbGlobalniAlfa.TabIndex = 0;
            this.tbGlobalniAlfa.Text = "5";
            // 
            // lblGlobalniAlfa
            // 
            this.lblGlobalniAlfa.AutoSize = true;
            this.lblGlobalniAlfa.Location = new System.Drawing.Point(28, 22);
            this.lblGlobalniAlfa.Name = "lblGlobalniAlfa";
            this.lblGlobalniAlfa.Size = new System.Drawing.Size(16, 13);
            this.lblGlobalniAlfa.TabIndex = 0;
            this.lblGlobalniAlfa.Text = "a:";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.btnIzjednaci);
            this.groupBox7.Controls.Add(this.btnFormirajMatrice);
            this.groupBox7.Location = new System.Drawing.Point(8, 432);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 77);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Izjednačenje";
            // 
            // btnIzjednaci
            // 
            this.btnIzjednaci.Enabled = false;
            this.btnIzjednaci.Location = new System.Drawing.Point(6, 48);
            this.btnIzjednaci.Name = "btnIzjednaci";
            this.btnIzjednaci.Size = new System.Drawing.Size(151, 23);
            this.btnIzjednaci.TabIndex = 2;
            this.btnIzjednaci.Text = "Pokretanje izjednačenja";
            this.btnIzjednaci.UseVisualStyleBackColor = true;
            this.btnIzjednaci.Click += new System.EventHandler(this.btnIzjednaci_Click);
            // 
            // btnFormirajMatrice
            // 
            this.btnFormirajMatrice.Location = new System.Drawing.Point(6, 19);
            this.btnFormirajMatrice.Name = "btnFormirajMatrice";
            this.btnFormirajMatrice.Size = new System.Drawing.Size(151, 23);
            this.btnFormirajMatrice.TabIndex = 1;
            this.btnFormirajMatrice.Text = "Formiranje matrica";
            this.btnFormirajMatrice.UseVisualStyleBackColor = true;
            this.btnFormirajMatrice.Click += new System.EventHandler(this.btnFormirajMatrice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.ckbBazniVektor);
            this.groupBox1.Controls.Add(this.ckbDuzina);
            this.groupBox1.Controls.Add(this.ckbKut);
            this.groupBox1.Controls.Add(this.ckbPravac);
            this.groupBox1.Controls.Add(this.ckbAzimut);
            this.groupBox1.Location = new System.Drawing.Point(8, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrste mjerenja";
            // 
            // ckbBazniVektor
            // 
            this.ckbBazniVektor.AutoSize = true;
            this.ckbBazniVektor.Checked = true;
            this.ckbBazniVektor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbBazniVektor.Location = new System.Drawing.Point(18, 111);
            this.ckbBazniVektor.Name = "ckbBazniVektor";
            this.ckbBazniVektor.Size = new System.Drawing.Size(85, 17);
            this.ckbBazniVektor.TabIndex = 4;
            this.ckbBazniVektor.Text = "Bazni vektor";
            this.ckbBazniVektor.UseVisualStyleBackColor = true;
            this.ckbBazniVektor.CheckedChanged += new System.EventHandler(this.ckbBazniVektor_CheckedChanged);
            // 
            // ckbDuzina
            // 
            this.ckbDuzina.AutoSize = true;
            this.ckbDuzina.Checked = true;
            this.ckbDuzina.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDuzina.Location = new System.Drawing.Point(18, 88);
            this.ckbDuzina.Name = "ckbDuzina";
            this.ckbDuzina.Size = new System.Drawing.Size(59, 17);
            this.ckbDuzina.TabIndex = 3;
            this.ckbDuzina.Text = "Dužina";
            this.ckbDuzina.UseVisualStyleBackColor = true;
            this.ckbDuzina.CheckedChanged += new System.EventHandler(this.ckbDuzina_CheckedChanged);
            // 
            // ckbKut
            // 
            this.ckbKut.AutoSize = true;
            this.ckbKut.Checked = true;
            this.ckbKut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKut.Location = new System.Drawing.Point(18, 65);
            this.ckbKut.Name = "ckbKut";
            this.ckbKut.Size = new System.Drawing.Size(75, 17);
            this.ckbKut.TabIndex = 2;
            this.ckbKut.Text = "Kut (ugao)";
            this.ckbKut.UseVisualStyleBackColor = true;
            this.ckbKut.CheckedChanged += new System.EventHandler(this.ckbKut_CheckedChanged);
            // 
            // ckbPravac
            // 
            this.ckbPravac.AutoSize = true;
            this.ckbPravac.Checked = true;
            this.ckbPravac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPravac.Location = new System.Drawing.Point(18, 42);
            this.ckbPravac.Name = "ckbPravac";
            this.ckbPravac.Size = new System.Drawing.Size(60, 17);
            this.ckbPravac.TabIndex = 1;
            this.ckbPravac.Text = "Pravac";
            this.ckbPravac.UseVisualStyleBackColor = true;
            this.ckbPravac.CheckedChanged += new System.EventHandler(this.ckbPravac_CheckedChanged);
            // 
            // ckbAzimut
            // 
            this.ckbAzimut.AutoSize = true;
            this.ckbAzimut.Checked = true;
            this.ckbAzimut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAzimut.Location = new System.Drawing.Point(18, 19);
            this.ckbAzimut.Name = "ckbAzimut";
            this.ckbAzimut.Size = new System.Drawing.Size(57, 17);
            this.ckbAzimut.TabIndex = 0;
            this.ckbAzimut.Text = "Azimut";
            this.ckbAzimut.UseVisualStyleBackColor = true;
            this.ckbAzimut.CheckedChanged += new System.EventHandler(this.ckbAzimut_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tbSigmaNulaKvadrat);
            this.groupBox2.Controls.Add(this.tbSigmaNula);
            this.groupBox2.Controls.Add(this.lblSigmaNulaKvadrat);
            this.groupBox2.Controls.Add(this.lblSigmaNula);
            this.groupBox2.Location = new System.Drawing.Point(8, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A priori";
            // 
            // tbSigmaNulaKvadrat
            // 
            this.tbSigmaNulaKvadrat.Location = new System.Drawing.Point(114, 19);
            this.tbSigmaNulaKvadrat.Name = "tbSigmaNulaKvadrat";
            this.tbSigmaNulaKvadrat.Size = new System.Drawing.Size(33, 20);
            this.tbSigmaNulaKvadrat.TabIndex = 2;
            this.tbSigmaNulaKvadrat.Text = "1";
            this.tbSigmaNulaKvadrat.TextChanged += new System.EventHandler(this.tbSigmaNulaKvadrat_TextChanged);
            this.tbSigmaNulaKvadrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSigmaNulaKvadrat_KeyPress);
            // 
            // tbSigmaNula
            // 
            this.tbSigmaNula.Location = new System.Drawing.Point(45, 19);
            this.tbSigmaNula.Name = "tbSigmaNula";
            this.tbSigmaNula.Size = new System.Drawing.Size(33, 20);
            this.tbSigmaNula.TabIndex = 0;
            this.tbSigmaNula.Text = "1";
            this.tbSigmaNula.TextChanged += new System.EventHandler(this.tbSigmaNula_TextChanged);
            this.tbSigmaNula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSigmaNula_KeyPress);
            // 
            // lblSigmaNulaKvadrat
            // 
            this.lblSigmaNulaKvadrat.AutoSize = true;
            this.lblSigmaNulaKvadrat.Location = new System.Drawing.Point(84, 22);
            this.lblSigmaNulaKvadrat.Name = "lblSigmaNulaKvadrat";
            this.lblSigmaNulaKvadrat.Size = new System.Drawing.Size(24, 13);
            this.lblSigmaNulaKvadrat.TabIndex = 1;
            this.lblSigmaNulaKvadrat.Text = "s02";
            // 
            // lblSigmaNula
            // 
            this.lblSigmaNula.AutoSize = true;
            this.lblSigmaNula.Location = new System.Drawing.Point(15, 22);
            this.lblSigmaNula.Name = "lblSigmaNula";
            this.lblSigmaNula.Size = new System.Drawing.Size(18, 13);
            this.lblSigmaNula.TabIndex = 0;
            this.lblSigmaNula.Text = "s0";
            // 
            // gbVrstaIzjednacenja
            // 
            this.gbVrstaIzjednacenja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVrstaIzjednacenja.Controls.Add(this.rbIzjednacenjePrisila);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbKlasicanNacin);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbParcijalniMinimalniTrag);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbMinimalniTrag);
            this.gbVrstaIzjednacenja.Location = new System.Drawing.Point(8, 12);
            this.gbVrstaIzjednacenja.Name = "gbVrstaIzjednacenja";
            this.gbVrstaIzjednacenja.Size = new System.Drawing.Size(163, 113);
            this.gbVrstaIzjednacenja.TabIndex = 1;
            this.gbVrstaIzjednacenja.TabStop = false;
            this.gbVrstaIzjednacenja.Text = "Vrsta izjednačenja";
            // 
            // rbIzjednacenjePrisila
            // 
            this.rbIzjednacenjePrisila.AutoSize = true;
            this.rbIzjednacenjePrisila.Location = new System.Drawing.Point(6, 91);
            this.rbIzjednacenjePrisila.Name = "rbIzjednacenjePrisila";
            this.rbIzjednacenjePrisila.Size = new System.Drawing.Size(124, 17);
            this.rbIzjednacenjePrisila.TabIndex = 2;
            this.rbIzjednacenjePrisila.Text = "Izjednačnje s prisilom";
            this.rbIzjednacenjePrisila.UseVisualStyleBackColor = true;
            this.rbIzjednacenjePrisila.CheckedChanged += new System.EventHandler(this.rbIzjednacenjePrisila_CheckedChanged);
            // 
            // rbKlasicanNacin
            // 
            this.rbKlasicanNacin.AutoSize = true;
            this.rbKlasicanNacin.Location = new System.Drawing.Point(6, 68);
            this.rbKlasicanNacin.Name = "rbKlasicanNacin";
            this.rbKlasicanNacin.Size = new System.Drawing.Size(94, 17);
            this.rbKlasicanNacin.TabIndex = 1;
            this.rbKlasicanNacin.Text = "Klasičan način";
            this.rbKlasicanNacin.UseVisualStyleBackColor = true;
            this.rbKlasicanNacin.CheckedChanged += new System.EventHandler(this.rbKlasicanNacin_CheckedChanged);
            // 
            // rbParcijalniMinimalniTrag
            // 
            this.rbParcijalniMinimalniTrag.AutoSize = true;
            this.rbParcijalniMinimalniTrag.Location = new System.Drawing.Point(6, 45);
            this.rbParcijalniMinimalniTrag.Name = "rbParcijalniMinimalniTrag";
            this.rbParcijalniMinimalniTrag.Size = new System.Drawing.Size(133, 17);
            this.rbParcijalniMinimalniTrag.TabIndex = 0;
            this.rbParcijalniMinimalniTrag.Text = "Parcijalni minimalni trag";
            this.rbParcijalniMinimalniTrag.UseVisualStyleBackColor = true;
            this.rbParcijalniMinimalniTrag.CheckedChanged += new System.EventHandler(this.rbParcijalniMinimalniTrag_CheckedChanged);
            // 
            // rbMinimalniTrag
            // 
            this.rbMinimalniTrag.AutoSize = true;
            this.rbMinimalniTrag.Checked = true;
            this.rbMinimalniTrag.Location = new System.Drawing.Point(6, 22);
            this.rbMinimalniTrag.Name = "rbMinimalniTrag";
            this.rbMinimalniTrag.Size = new System.Drawing.Size(89, 17);
            this.rbMinimalniTrag.TabIndex = 0;
            this.rbMinimalniTrag.TabStop = true;
            this.rbMinimalniTrag.Text = "Minimalni trag";
            this.rbMinimalniTrag.UseVisualStyleBackColor = true;
            this.rbMinimalniTrag.CheckedChanged += new System.EventHandler(this.rbMinimalniTrag_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpTocke);
            this.tabControl.Controls.Add(this.tpAzimut);
            this.tabControl.Controls.Add(this.tpPravac);
            this.tabControl.Controls.Add(this.tpKut);
            this.tabControl.Controls.Add(this.tpDuzina);
            this.tabControl.Controls.Add(this.tpBazniVektor);
            this.tabControl.Controls.Add(this.tpA);
            this.tabControl.Controls.Add(this.tpP);
            this.tabControl.Controls.Add(this.tpF);
            this.tabControl.Controls.Add(this.tpG);
            this.tabControl.Controls.Add(this.tpIzjednacenje);
            this.tabControl.Controls.Add(this.OcjenaFunkcija);
            this.tabControl.Controls.Add(this.IzjednaceneVelicine);
            this.tabControl.Controls.Add(this.tpStatistika);
            this.tabControl.Controls.Add(this.tpTestPouzdanostiFigure);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(701, 516);
            this.tabControl.TabIndex = 0;
            // 
            // tpTocke
            // 
            this.tpTocke.Controls.Add(this.splitContainer2);
            this.tpTocke.Location = new System.Drawing.Point(4, 22);
            this.tpTocke.Name = "tpTocke";
            this.tpTocke.Padding = new System.Windows.Forms.Padding(3);
            this.tpTocke.Size = new System.Drawing.Size(693, 490);
            this.tpTocke.TabIndex = 0;
            this.tpTocke.Text = "Točke";
            this.tpTocke.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbKlasicanNacin);
            this.splitContainer2.Panel1.Controls.Add(this.gb2Dkoordinate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvTocka);
            this.splitContainer2.Panel2.Controls.Add(this.lvX);
            this.splitContainer2.Panel2.Controls.Add(this.lvY);
            this.splitContainer2.Size = new System.Drawing.Size(687, 484);
            this.splitContainer2.SplitterDistance = 199;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbKlasicanNacin
            // 
            this.gbKlasicanNacin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbKlasicanNacin.Controls.Add(this.ckbKlasicanKoordinata);
            this.gbKlasicanNacin.Controls.Add(this.ckbKlasicanBazniVektor);
            this.gbKlasicanNacin.Controls.Add(this.ckbKlasicanDuzina);
            this.gbKlasicanNacin.Controls.Add(this.ckbKlasicanAzimut);
            this.gbKlasicanNacin.Controls.Add(this.gbKlasicanMjerilo);
            this.gbKlasicanNacin.Controls.Add(this.gbKlasicanRotacija);
            this.gbKlasicanNacin.Controls.Add(this.groupBox3);
            this.gbKlasicanNacin.Enabled = false;
            this.gbKlasicanNacin.Location = new System.Drawing.Point(13, 147);
            this.gbKlasicanNacin.Name = "gbKlasicanNacin";
            this.gbKlasicanNacin.Size = new System.Drawing.Size(177, 334);
            this.gbKlasicanNacin.TabIndex = 4;
            this.gbKlasicanNacin.TabStop = false;
            this.gbKlasicanNacin.Text = "Datum: klasican način";
            this.gbKlasicanNacin.Visible = false;
            // 
            // ckbKlasicanKoordinata
            // 
            this.ckbKlasicanKoordinata.AutoSize = true;
            this.ckbKlasicanKoordinata.Checked = true;
            this.ckbKlasicanKoordinata.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKlasicanKoordinata.Location = new System.Drawing.Point(15, 146);
            this.ckbKlasicanKoordinata.Name = "ckbKlasicanKoordinata";
            this.ckbKlasicanKoordinata.Size = new System.Drawing.Size(77, 17);
            this.ckbKlasicanKoordinata.TabIndex = 12;
            this.ckbKlasicanKoordinata.Text = "Koordinata";
            this.ckbKlasicanKoordinata.UseVisualStyleBackColor = true;
            this.ckbKlasicanKoordinata.CheckedChanged += new System.EventHandler(this.ckbKlasicanKoordinata_CheckedChanged);
            // 
            // ckbKlasicanBazniVektor
            // 
            this.ckbKlasicanBazniVektor.AutoSize = true;
            this.ckbKlasicanBazniVektor.Location = new System.Drawing.Point(15, 123);
            this.ckbKlasicanBazniVektor.Name = "ckbKlasicanBazniVektor";
            this.ckbKlasicanBazniVektor.Size = new System.Drawing.Size(85, 17);
            this.ckbKlasicanBazniVektor.TabIndex = 11;
            this.ckbKlasicanBazniVektor.Text = "Bazni vektor";
            this.ckbKlasicanBazniVektor.UseVisualStyleBackColor = true;
            this.ckbKlasicanBazniVektor.CheckedChanged += new System.EventHandler(this.ckbKlasicanBazniVektor_CheckedChanged);
            // 
            // ckbKlasicanDuzina
            // 
            this.ckbKlasicanDuzina.AutoSize = true;
            this.ckbKlasicanDuzina.Location = new System.Drawing.Point(15, 100);
            this.ckbKlasicanDuzina.Name = "ckbKlasicanDuzina";
            this.ckbKlasicanDuzina.Size = new System.Drawing.Size(59, 17);
            this.ckbKlasicanDuzina.TabIndex = 10;
            this.ckbKlasicanDuzina.Text = "Dužina";
            this.ckbKlasicanDuzina.UseVisualStyleBackColor = true;
            this.ckbKlasicanDuzina.CheckedChanged += new System.EventHandler(this.ckbKlasicanDuzina_CheckedChanged);
            // 
            // ckbKlasicanAzimut
            // 
            this.ckbKlasicanAzimut.AutoSize = true;
            this.ckbKlasicanAzimut.Location = new System.Drawing.Point(15, 77);
            this.ckbKlasicanAzimut.Name = "ckbKlasicanAzimut";
            this.ckbKlasicanAzimut.Size = new System.Drawing.Size(149, 17);
            this.ckbKlasicanAzimut.TabIndex = 9;
            this.ckbKlasicanAzimut.Text = "Azimut (orijentirani pravac)";
            this.ckbKlasicanAzimut.UseVisualStyleBackColor = true;
            this.ckbKlasicanAzimut.CheckedChanged += new System.EventHandler(this.ckbKlasicanAzimut_CheckedChanged);
            // 
            // gbKlasicanMjerilo
            // 
            this.gbKlasicanMjerilo.Controls.Add(this.lblKlasicanMvizura);
            this.gbKlasicanMjerilo.Controls.Add(this.cmbKlasicanMvizura);
            this.gbKlasicanMjerilo.Controls.Add(this.lblKlasicanMstajaliste);
            this.gbKlasicanMjerilo.Controls.Add(this.cmbKlasicanMstajaliste);
            this.gbKlasicanMjerilo.Location = new System.Drawing.Point(6, 249);
            this.gbKlasicanMjerilo.Name = "gbKlasicanMjerilo";
            this.gbKlasicanMjerilo.Size = new System.Drawing.Size(165, 79);
            this.gbKlasicanMjerilo.TabIndex = 8;
            this.gbKlasicanMjerilo.TabStop = false;
            this.gbKlasicanMjerilo.Text = "Mjerilo";
            // 
            // lblKlasicanMvizura
            // 
            this.lblKlasicanMvizura.AutoSize = true;
            this.lblKlasicanMvizura.Location = new System.Drawing.Point(18, 49);
            this.lblKlasicanMvizura.Name = "lblKlasicanMvizura";
            this.lblKlasicanMvizura.Size = new System.Drawing.Size(39, 13);
            this.lblKlasicanMvizura.TabIndex = 11;
            this.lblKlasicanMvizura.Text = "Vizura:";
            // 
            // cmbKlasicanMvizura
            // 
            this.cmbKlasicanMvizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanMvizura.FormattingEnabled = true;
            this.cmbKlasicanMvizura.Location = new System.Drawing.Point(73, 46);
            this.cmbKlasicanMvizura.Name = "cmbKlasicanMvizura";
            this.cmbKlasicanMvizura.Size = new System.Drawing.Size(85, 21);
            this.cmbKlasicanMvizura.TabIndex = 8;
            // 
            // lblKlasicanMstajaliste
            // 
            this.lblKlasicanMstajaliste.AutoSize = true;
            this.lblKlasicanMstajaliste.Location = new System.Drawing.Point(6, 22);
            this.lblKlasicanMstajaliste.Name = "lblKlasicanMstajaliste";
            this.lblKlasicanMstajaliste.Size = new System.Drawing.Size(52, 13);
            this.lblKlasicanMstajaliste.TabIndex = 10;
            this.lblKlasicanMstajaliste.Text = "Stajalište:";
            // 
            // cmbKlasicanMstajaliste
            // 
            this.cmbKlasicanMstajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanMstajaliste.FormattingEnabled = true;
            this.cmbKlasicanMstajaliste.Location = new System.Drawing.Point(73, 19);
            this.cmbKlasicanMstajaliste.Name = "cmbKlasicanMstajaliste";
            this.cmbKlasicanMstajaliste.Size = new System.Drawing.Size(86, 21);
            this.cmbKlasicanMstajaliste.TabIndex = 7;
            this.cmbKlasicanMstajaliste.SelectedIndexChanged += new System.EventHandler(this.cmbKlasicanMstajaliste_SelectedIndexChanged);
            // 
            // gbKlasicanRotacija
            // 
            this.gbKlasicanRotacija.Controls.Add(this.lblKlasicanRvizura);
            this.gbKlasicanRotacija.Controls.Add(this.lblKlasicanRstajaliste);
            this.gbKlasicanRotacija.Controls.Add(this.cmbKlasicanRvizura);
            this.gbKlasicanRotacija.Controls.Add(this.cmbKlasicanRstajaliste);
            this.gbKlasicanRotacija.Location = new System.Drawing.Point(6, 169);
            this.gbKlasicanRotacija.Name = "gbKlasicanRotacija";
            this.gbKlasicanRotacija.Size = new System.Drawing.Size(165, 76);
            this.gbKlasicanRotacija.TabIndex = 7;
            this.gbKlasicanRotacija.TabStop = false;
            this.gbKlasicanRotacija.Text = "Rotacija";
            // 
            // lblKlasicanRvizura
            // 
            this.lblKlasicanRvizura.AutoSize = true;
            this.lblKlasicanRvizura.Location = new System.Drawing.Point(19, 52);
            this.lblKlasicanRvizura.Name = "lblKlasicanRvizura";
            this.lblKlasicanRvizura.Size = new System.Drawing.Size(39, 13);
            this.lblKlasicanRvizura.TabIndex = 9;
            this.lblKlasicanRvizura.Text = "Vizura:";
            // 
            // lblKlasicanRstajaliste
            // 
            this.lblKlasicanRstajaliste.AutoSize = true;
            this.lblKlasicanRstajaliste.Location = new System.Drawing.Point(6, 25);
            this.lblKlasicanRstajaliste.Name = "lblKlasicanRstajaliste";
            this.lblKlasicanRstajaliste.Size = new System.Drawing.Size(52, 13);
            this.lblKlasicanRstajaliste.TabIndex = 8;
            this.lblKlasicanRstajaliste.Text = "Stajalište:";
            // 
            // cmbKlasicanRvizura
            // 
            this.cmbKlasicanRvizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanRvizura.FormattingEnabled = true;
            this.cmbKlasicanRvizura.Location = new System.Drawing.Point(73, 49);
            this.cmbKlasicanRvizura.Name = "cmbKlasicanRvizura";
            this.cmbKlasicanRvizura.Size = new System.Drawing.Size(85, 21);
            this.cmbKlasicanRvizura.TabIndex = 7;
            // 
            // cmbKlasicanRstajaliste
            // 
            this.cmbKlasicanRstajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanRstajaliste.FormattingEnabled = true;
            this.cmbKlasicanRstajaliste.Location = new System.Drawing.Point(73, 22);
            this.cmbKlasicanRstajaliste.Name = "cmbKlasicanRstajaliste";
            this.cmbKlasicanRstajaliste.Size = new System.Drawing.Size(86, 21);
            this.cmbKlasicanRstajaliste.TabIndex = 6;
            this.cmbKlasicanRstajaliste.SelectedIndexChanged += new System.EventHandler(this.cmbKlasicanRstajaliste_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbKlasicanX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbKlasicanY);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Translacija";
            // 
            // cmbKlasicanX
            // 
            this.cmbKlasicanX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanX.FormattingEnabled = true;
            this.cmbKlasicanX.Location = new System.Drawing.Point(108, 19);
            this.cmbKlasicanX.Name = "cmbKlasicanX";
            this.cmbKlasicanX.Size = new System.Drawing.Size(50, 21);
            this.cmbKlasicanX.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y:";
            // 
            // cmbKlasicanY
            // 
            this.cmbKlasicanY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasicanY.FormattingEnabled = true;
            this.cmbKlasicanY.Location = new System.Drawing.Point(29, 19);
            this.cmbKlasicanY.Name = "cmbKlasicanY";
            this.cmbKlasicanY.Size = new System.Drawing.Size(50, 21);
            this.cmbKlasicanY.TabIndex = 4;
            // 
            // gb2Dkoordinate
            // 
            this.gb2Dkoordinate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2Dkoordinate.Controls.Add(this.btnDodajTocku);
            this.gb2Dkoordinate.Controls.Add(this.lbl2Dx);
            this.gb2Dkoordinate.Controls.Add(this.lbl2Dy);
            this.gb2Dkoordinate.Controls.Add(this.lbl2Dtocka);
            this.gb2Dkoordinate.Controls.Add(this.tbX);
            this.gb2Dkoordinate.Controls.Add(this.tbY);
            this.gb2Dkoordinate.Controls.Add(this.tbTocka);
            this.gb2Dkoordinate.Location = new System.Drawing.Point(13, 12);
            this.gb2Dkoordinate.Name = "gb2Dkoordinate";
            this.gb2Dkoordinate.Size = new System.Drawing.Size(177, 129);
            this.gb2Dkoordinate.TabIndex = 1;
            this.gb2Dkoordinate.TabStop = false;
            this.gb2Dkoordinate.Text = "Dodaj/Izmjeni podatke";
            // 
            // btnDodajTocku
            // 
            this.btnDodajTocku.Location = new System.Drawing.Point(89, 98);
            this.btnDodajTocku.Name = "btnDodajTocku";
            this.btnDodajTocku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTocku.TabIndex = 8;
            this.btnDodajTocku.Text = "Dodaj";
            this.btnDodajTocku.UseVisualStyleBackColor = true;
            this.btnDodajTocku.Click += new System.EventHandler(this.btnDodajTocku_Click);
            // 
            // lbl2Dx
            // 
            this.lbl2Dx.AutoSize = true;
            this.lbl2Dx.Location = new System.Drawing.Point(41, 75);
            this.lbl2Dx.Name = "lbl2Dx";
            this.lbl2Dx.Size = new System.Drawing.Size(17, 13);
            this.lbl2Dx.TabIndex = 5;
            this.lbl2Dx.Text = "X:";
            // 
            // lbl2Dy
            // 
            this.lbl2Dy.AutoSize = true;
            this.lbl2Dy.Location = new System.Drawing.Point(41, 49);
            this.lbl2Dy.Name = "lbl2Dy";
            this.lbl2Dy.Size = new System.Drawing.Size(17, 13);
            this.lbl2Dy.TabIndex = 4;
            this.lbl2Dy.Text = "Y:";
            // 
            // lbl2Dtocka
            // 
            this.lbl2Dtocka.AutoSize = true;
            this.lbl2Dtocka.Location = new System.Drawing.Point(17, 23);
            this.lbl2Dtocka.Name = "lbl2Dtocka";
            this.lbl2Dtocka.Size = new System.Drawing.Size(41, 13);
            this.lbl2Dtocka.TabIndex = 3;
            this.lbl2Dtocka.Text = "Točka:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(64, 72);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 2;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbX_KeyPress);
            this.tbX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbX_KeyUp);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(64, 46);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 1;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbY_KeyPress);
            this.tbY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbY_KeyUp);
            // 
            // tbTocka
            // 
            this.tbTocka.Location = new System.Drawing.Point(64, 20);
            this.tbTocka.Name = "tbTocka";
            this.tbTocka.Size = new System.Drawing.Size(100, 20);
            this.tbTocka.TabIndex = 0;
            this.tbTocka.TextChanged += new System.EventHandler(this.tbTocka_TextChanged);
            this.tbTocka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTocka_KeyUp);
            // 
            // lvTocka
            // 
            this.lvTocka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvTocka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tocka});
            this.lvTocka.FullRowSelect = true;
            this.lvTocka.GridLines = true;
            this.lvTocka.Location = new System.Drawing.Point(15, 9);
            this.lvTocka.MultiSelect = false;
            this.lvTocka.Name = "lvTocka";
            this.lvTocka.Size = new System.Drawing.Size(118, 472);
            this.lvTocka.TabIndex = 3;
            this.lvTocka.UseCompatibleStateImageBehavior = false;
            this.lvTocka.View = System.Windows.Forms.View.Details;
            this.lvTocka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvTocka_MouseDown);
            // 
            // tocka
            // 
            this.tocka.Text = "Točka";
            this.tocka.Width = 101;
            // 
            // lvX
            // 
            this.lvX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvX.CheckBoxes = true;
            this.lvX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.x});
            this.lvX.FullRowSelect = true;
            this.lvX.GridLines = true;
            this.lvX.Location = new System.Drawing.Point(305, 9);
            this.lvX.MultiSelect = false;
            this.lvX.Name = "lvX";
            this.lvX.Size = new System.Drawing.Size(160, 472);
            this.lvX.TabIndex = 2;
            this.lvX.UseCompatibleStateImageBehavior = false;
            this.lvX.View = System.Windows.Forms.View.Details;
            this.lvX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvX_MouseDown);
            // 
            // x
            // 
            this.x.Text = "[Datum] X";
            this.x.Width = 99;
            // 
            // lvY
            // 
            this.lvY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvY.CheckBoxes = true;
            this.lvY.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Y});
            this.lvY.FullRowSelect = true;
            this.lvY.GridLines = true;
            this.lvY.Location = new System.Drawing.Point(139, 9);
            this.lvY.MultiSelect = false;
            this.lvY.Name = "lvY";
            this.lvY.Size = new System.Drawing.Size(160, 472);
            this.lvY.TabIndex = 1;
            this.lvY.UseCompatibleStateImageBehavior = false;
            this.lvY.View = System.Windows.Forms.View.Details;
            this.lvY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvY_MouseDown);
            // 
            // Y
            // 
            this.Y.Text = "[Datum] Y";
            this.Y.Width = 99;
            // 
            // tpAzimut
            // 
            this.tpAzimut.Controls.Add(this.pnlAzimut);
            this.tpAzimut.Location = new System.Drawing.Point(4, 22);
            this.tpAzimut.Name = "tpAzimut";
            this.tpAzimut.Padding = new System.Windows.Forms.Padding(3);
            this.tpAzimut.Size = new System.Drawing.Size(693, 490);
            this.tpAzimut.TabIndex = 1;
            this.tpAzimut.Text = "Azimut";
            this.tpAzimut.UseVisualStyleBackColor = true;
            // 
            // pnlAzimut
            // 
            this.pnlAzimut.Controls.Add(this.splitContainer3);
            this.pnlAzimut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAzimut.Location = new System.Drawing.Point(3, 3);
            this.pnlAzimut.Name = "pnlAzimut";
            this.pnlAzimut.Size = new System.Drawing.Size(687, 484);
            this.pnlAzimut.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.rtbAzimuti2dOpis);
            this.splitContainer3.Panel1.Controls.Add(this.gb2dMjerenjeAzimuti);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gb2dAzimutiMjerenja);
            this.splitContainer3.Size = new System.Drawing.Size(687, 484);
            this.splitContainer3.SplitterDistance = 244;
            this.splitContainer3.TabIndex = 0;
            // 
            // rtbAzimuti2dOpis
            // 
            this.rtbAzimuti2dOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAzimuti2dOpis.Location = new System.Drawing.Point(3, 300);
            this.rtbAzimuti2dOpis.Name = "rtbAzimuti2dOpis";
            this.rtbAzimuti2dOpis.Size = new System.Drawing.Size(235, 181);
            this.rtbAzimuti2dOpis.TabIndex = 5;
            this.rtbAzimuti2dOpis.Text = "";
            // 
            // gb2dMjerenjeAzimuti
            // 
            this.gb2dMjerenjeAzimuti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiTolerancija);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.tb2dAzimutiTolarancija);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.gb2dAzimutiTezine);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.btn2dDodajAzimut);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiSekunde);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiMinute);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiStupnjevi);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.tb2dAzimutiSekunde);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.tb2dAzimutiMinute);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.tb2dAzimutiStupnjevi);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.cmb2dAzimutiVizura);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiMjerenje);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.cmb2DazimutiStajaliste);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiVizura);
            this.gb2dMjerenjeAzimuti.Controls.Add(this.lbl2dAzimutiStajaliste);
            this.gb2dMjerenjeAzimuti.Location = new System.Drawing.Point(3, 9);
            this.gb2dMjerenjeAzimuti.Name = "gb2dMjerenjeAzimuti";
            this.gb2dMjerenjeAzimuti.Size = new System.Drawing.Size(235, 285);
            this.gb2dMjerenjeAzimuti.TabIndex = 3;
            this.gb2dMjerenjeAzimuti.TabStop = false;
            this.gb2dMjerenjeAzimuti.Text = "Mjerenje";
            // 
            // lbl2dAzimutiTolerancija
            // 
            this.lbl2dAzimutiTolerancija.AutoSize = true;
            this.lbl2dAzimutiTolerancija.Location = new System.Drawing.Point(6, 222);
            this.lbl2dAzimutiTolerancija.Name = "lbl2dAzimutiTolerancija";
            this.lbl2dAzimutiTolerancija.Size = new System.Drawing.Size(166, 13);
            this.lbl2dAzimutiTolerancija.TabIndex = 12;
            this.lbl2dAzimutiTolerancija.Text = "Tolerancija odstupanja azimuta [\'\']";
            // 
            // tb2dAzimutiTolarancija
            // 
            this.tb2dAzimutiTolarancija.Location = new System.Drawing.Point(202, 219);
            this.tb2dAzimutiTolarancija.Name = "tb2dAzimutiTolarancija";
            this.tb2dAzimutiTolarancija.Size = new System.Drawing.Size(23, 20);
            this.tb2dAzimutiTolarancija.TabIndex = 11;
            this.tb2dAzimutiTolarancija.Text = "5";
            this.tb2dAzimutiTolarancija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutiTolarancija_KeyPress);
            // 
            // gb2dAzimutiTezine
            // 
            this.gb2dAzimutiTezine.Controls.Add(this.rb2dAzimutiBrojTocaka);
            this.gb2dAzimutiTezine.Controls.Add(this.tb2dAzimutBrojTocaka);
            this.gb2dAzimutiTezine.Controls.Add(this.lbl2dAzimutSigmaSekunde);
            this.gb2dAzimutiTezine.Controls.Add(this.tb2dAzimutTezina);
            this.gb2dAzimutiTezine.Controls.Add(this.tb2dAzimutSigma);
            this.gb2dAzimutiTezine.Controls.Add(this.rb2dAzimutiTezina);
            this.gb2dAzimutiTezine.Controls.Add(this.rb2dAzimutiSigma);
            this.gb2dAzimutiTezine.Location = new System.Drawing.Point(9, 100);
            this.gb2dAzimutiTezine.Name = "gb2dAzimutiTezine";
            this.gb2dAzimutiTezine.Size = new System.Drawing.Size(216, 106);
            this.gb2dAzimutiTezine.TabIndex = 10;
            this.gb2dAzimutiTezine.TabStop = false;
            this.gb2dAzimutiTezine.Text = "Težina";
            // 
            // rb2dAzimutiBrojTocaka
            // 
            this.rb2dAzimutiBrojTocaka.AutoSize = true;
            this.rb2dAzimutiBrojTocaka.Location = new System.Drawing.Point(13, 45);
            this.rb2dAzimutiBrojTocaka.Name = "rb2dAzimutiBrojTocaka";
            this.rb2dAzimutiBrojTocaka.Size = new System.Drawing.Size(128, 17);
            this.rb2dAzimutiBrojTocaka.TabIndex = 14;
            this.rb2dAzimutiBrojTocaka.Text = "Broj opažanih točaka:";
            this.rb2dAzimutiBrojTocaka.UseVisualStyleBackColor = true;
            this.rb2dAzimutiBrojTocaka.CheckedChanged += new System.EventHandler(this.rb2dAzimutiBrojTocaka_CheckedChanged);
            // 
            // tb2dAzimutBrojTocaka
            // 
            this.tb2dAzimutBrojTocaka.Enabled = false;
            this.tb2dAzimutBrojTocaka.Location = new System.Drawing.Point(147, 44);
            this.tb2dAzimutBrojTocaka.MaxLength = 6;
            this.tb2dAzimutBrojTocaka.Name = "tb2dAzimutBrojTocaka";
            this.tb2dAzimutBrojTocaka.Size = new System.Drawing.Size(50, 20);
            this.tb2dAzimutBrojTocaka.TabIndex = 13;
            this.tb2dAzimutBrojTocaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutBrojTocaka_KeyPress);
            // 
            // lbl2dAzimutSigmaSekunde
            // 
            this.lbl2dAzimutSigmaSekunde.AutoSize = true;
            this.lbl2dAzimutSigmaSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dAzimutSigmaSekunde.Location = new System.Drawing.Point(150, 16);
            this.lbl2dAzimutSigmaSekunde.Name = "lbl2dAzimutSigmaSekunde";
            this.lbl2dAzimutSigmaSekunde.Size = new System.Drawing.Size(13, 15);
            this.lbl2dAzimutSigmaSekunde.TabIndex = 11;
            this.lbl2dAzimutSigmaSekunde.Text = "\'\'";
            // 
            // tb2dAzimutTezina
            // 
            this.tb2dAzimutTezina.Enabled = false;
            this.tb2dAzimutTezina.Location = new System.Drawing.Point(76, 70);
            this.tb2dAzimutTezina.MaxLength = 6;
            this.tb2dAzimutTezina.Name = "tb2dAzimutTezina";
            this.tb2dAzimutTezina.Size = new System.Drawing.Size(69, 20);
            this.tb2dAzimutTezina.TabIndex = 12;
            this.tb2dAzimutTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutTezina_KeyPress);
            // 
            // tb2dAzimutSigma
            // 
            this.tb2dAzimutSigma.Location = new System.Drawing.Point(76, 18);
            this.tb2dAzimutSigma.MaxLength = 6;
            this.tb2dAzimutSigma.Name = "tb2dAzimutSigma";
            this.tb2dAzimutSigma.Size = new System.Drawing.Size(69, 20);
            this.tb2dAzimutSigma.TabIndex = 11;
            this.tb2dAzimutSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutSigma_KeyPress);
            // 
            // rb2dAzimutiTezina
            // 
            this.rb2dAzimutiTezina.AutoSize = true;
            this.rb2dAzimutiTezina.Location = new System.Drawing.Point(13, 71);
            this.rb2dAzimutiTezina.Name = "rb2dAzimutiTezina";
            this.rb2dAzimutiTezina.Size = new System.Drawing.Size(60, 17);
            this.rb2dAzimutiTezina.TabIndex = 1;
            this.rb2dAzimutiTezina.Text = "Težina:";
            this.rb2dAzimutiTezina.UseVisualStyleBackColor = true;
            this.rb2dAzimutiTezina.CheckedChanged += new System.EventHandler(this.rb2dAzimutiTezina_CheckedChanged);
            // 
            // rb2dAzimutiSigma
            // 
            this.rb2dAzimutiSigma.AutoSize = true;
            this.rb2dAzimutiSigma.Checked = true;
            this.rb2dAzimutiSigma.Location = new System.Drawing.Point(13, 19);
            this.rb2dAzimutiSigma.Name = "rb2dAzimutiSigma";
            this.rb2dAzimutiSigma.Size = new System.Drawing.Size(57, 17);
            this.rb2dAzimutiSigma.TabIndex = 0;
            this.rb2dAzimutiSigma.TabStop = true;
            this.rb2dAzimutiSigma.Text = "Sigma:";
            this.rb2dAzimutiSigma.UseVisualStyleBackColor = true;
            this.rb2dAzimutiSigma.CheckedChanged += new System.EventHandler(this.rb2dAzimutiSigma_CheckedChanged);
            // 
            // btn2dDodajAzimut
            // 
            this.btn2dDodajAzimut.Location = new System.Drawing.Point(150, 252);
            this.btn2dDodajAzimut.Name = "btn2dDodajAzimut";
            this.btn2dDodajAzimut.Size = new System.Drawing.Size(75, 23);
            this.btn2dDodajAzimut.TabIndex = 9;
            this.btn2dDodajAzimut.Text = "Dodaj";
            this.btn2dDodajAzimut.UseVisualStyleBackColor = true;
            this.btn2dDodajAzimut.Click += new System.EventHandler(this.btn2dDodajAzimut_Click);
            // 
            // lbl2dAzimutiSekunde
            // 
            this.lbl2dAzimutiSekunde.AutoSize = true;
            this.lbl2dAzimutiSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dAzimutiSekunde.Location = new System.Drawing.Point(212, 74);
            this.lbl2dAzimutiSekunde.Name = "lbl2dAzimutiSekunde";
            this.lbl2dAzimutiSekunde.Size = new System.Drawing.Size(13, 15);
            this.lbl2dAzimutiSekunde.TabIndex = 8;
            this.lbl2dAzimutiSekunde.Text = "\'\'";
            // 
            // lbl2dAzimutiMinute
            // 
            this.lbl2dAzimutiMinute.AutoSize = true;
            this.lbl2dAzimutiMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dAzimutiMinute.Location = new System.Drawing.Point(144, 74);
            this.lbl2dAzimutiMinute.Name = "lbl2dAzimutiMinute";
            this.lbl2dAzimutiMinute.Size = new System.Drawing.Size(10, 15);
            this.lbl2dAzimutiMinute.TabIndex = 7;
            this.lbl2dAzimutiMinute.Text = "\'";
            // 
            // lbl2dAzimutiStupnjevi
            // 
            this.lbl2dAzimutiStupnjevi.AutoSize = true;
            this.lbl2dAzimutiStupnjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dAzimutiStupnjevi.Location = new System.Drawing.Point(94, 75);
            this.lbl2dAzimutiStupnjevi.Name = "lbl2dAzimutiStupnjevi";
            this.lbl2dAzimutiStupnjevi.Size = new System.Drawing.Size(12, 15);
            this.lbl2dAzimutiStupnjevi.TabIndex = 6;
            this.lbl2dAzimutiStupnjevi.Text = "°";
            // 
            // tb2dAzimutiSekunde
            // 
            this.tb2dAzimutiSekunde.Location = new System.Drawing.Point(162, 73);
            this.tb2dAzimutiSekunde.MaxLength = 6;
            this.tb2dAzimutiSekunde.Name = "tb2dAzimutiSekunde";
            this.tb2dAzimutiSekunde.Size = new System.Drawing.Size(44, 20);
            this.tb2dAzimutiSekunde.TabIndex = 5;
            this.tb2dAzimutiSekunde.TextChanged += new System.EventHandler(this.tb2dAzimutiSekunde_TextChanged);
            this.tb2dAzimutiSekunde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutiSekunde_KeyPress);
            // 
            // tb2dAzimutiMinute
            // 
            this.tb2dAzimutiMinute.Location = new System.Drawing.Point(112, 74);
            this.tb2dAzimutiMinute.MaxLength = 2;
            this.tb2dAzimutiMinute.Name = "tb2dAzimutiMinute";
            this.tb2dAzimutiMinute.Size = new System.Drawing.Size(26, 20);
            this.tb2dAzimutiMinute.TabIndex = 4;
            this.tb2dAzimutiMinute.TextChanged += new System.EventHandler(this.tb2dAzimutiMinute_TextChanged);
            this.tb2dAzimutiMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutiMinute_KeyPress);
            // 
            // tb2dAzimutiStupnjevi
            // 
            this.tb2dAzimutiStupnjevi.Location = new System.Drawing.Point(63, 74);
            this.tb2dAzimutiStupnjevi.MaxLength = 3;
            this.tb2dAzimutiStupnjevi.Name = "tb2dAzimutiStupnjevi";
            this.tb2dAzimutiStupnjevi.Size = new System.Drawing.Size(28, 20);
            this.tb2dAzimutiStupnjevi.TabIndex = 3;
            this.tb2dAzimutiStupnjevi.TextChanged += new System.EventHandler(this.tb2dAzimutiStupnjevi_TextChanged);
            this.tb2dAzimutiStupnjevi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dAzimutiStupnjevi_KeyPress);
            // 
            // cmb2dAzimutiVizura
            // 
            this.cmb2dAzimutiVizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2dAzimutiVizura.FormattingEnabled = true;
            this.cmb2dAzimutiVizura.Location = new System.Drawing.Point(63, 47);
            this.cmb2dAzimutiVizura.Name = "cmb2dAzimutiVizura";
            this.cmb2dAzimutiVizura.Size = new System.Drawing.Size(162, 21);
            this.cmb2dAzimutiVizura.TabIndex = 1;
            // 
            // lbl2dAzimutiMjerenje
            // 
            this.lbl2dAzimutiMjerenje.AutoSize = true;
            this.lbl2dAzimutiMjerenje.Location = new System.Drawing.Point(6, 77);
            this.lbl2dAzimutiMjerenje.Name = "lbl2dAzimutiMjerenje";
            this.lbl2dAzimutiMjerenje.Size = new System.Drawing.Size(50, 13);
            this.lbl2dAzimutiMjerenje.TabIndex = 2;
            this.lbl2dAzimutiMjerenje.Text = "Mjerenje:";
            // 
            // cmb2DazimutiStajaliste
            // 
            this.cmb2DazimutiStajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DazimutiStajaliste.FormattingEnabled = true;
            this.cmb2DazimutiStajaliste.Location = new System.Drawing.Point(63, 20);
            this.cmb2DazimutiStajaliste.Name = "cmb2DazimutiStajaliste";
            this.cmb2DazimutiStajaliste.Size = new System.Drawing.Size(162, 21);
            this.cmb2DazimutiStajaliste.TabIndex = 0;
            this.cmb2DazimutiStajaliste.SelectedIndexChanged += new System.EventHandler(this.cmb2DazimutiStajaliste_SelectedIndexChanged);
            // 
            // lbl2dAzimutiVizura
            // 
            this.lbl2dAzimutiVizura.AutoSize = true;
            this.lbl2dAzimutiVizura.Location = new System.Drawing.Point(19, 50);
            this.lbl2dAzimutiVizura.Name = "lbl2dAzimutiVizura";
            this.lbl2dAzimutiVizura.Size = new System.Drawing.Size(39, 13);
            this.lbl2dAzimutiVizura.TabIndex = 1;
            this.lbl2dAzimutiVizura.Text = "Vizura:";
            // 
            // lbl2dAzimutiStajaliste
            // 
            this.lbl2dAzimutiStajaliste.AutoSize = true;
            this.lbl2dAzimutiStajaliste.Location = new System.Drawing.Point(6, 23);
            this.lbl2dAzimutiStajaliste.Name = "lbl2dAzimutiStajaliste";
            this.lbl2dAzimutiStajaliste.Size = new System.Drawing.Size(52, 13);
            this.lbl2dAzimutiStajaliste.TabIndex = 0;
            this.lbl2dAzimutiStajaliste.Text = "Stajalište:";
            // 
            // gb2dAzimutiMjerenja
            // 
            this.gb2dAzimutiMjerenja.Controls.Add(this.lvAzimut);
            this.gb2dAzimutiMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb2dAzimutiMjerenja.Location = new System.Drawing.Point(0, 0);
            this.gb2dAzimutiMjerenja.Name = "gb2dAzimutiMjerenja";
            this.gb2dAzimutiMjerenja.Size = new System.Drawing.Size(439, 484);
            this.gb2dAzimutiMjerenja.TabIndex = 1;
            this.gb2dAzimutiMjerenja.TabStop = false;
            this.gb2dAzimutiMjerenja.Text = "Mjerenja";
            // 
            // lvAzimut
            // 
            this.lvAzimut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AzimutKontrola,
            this.AzimutStajaliste,
            this.AzimutVizura,
            this.AzimutMjerene,
            this.AzimutKoordinate,
            this.AzimutF,
            this.AzimutiTezina,
            this.AzimutSigma,
            this.AzimutStDerivacijaY,
            this.AzimutStDerivacijaX,
            this.AzimutVzDerivacijaY,
            this.AzimutVzDerivacijaX});
            this.lvAzimut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAzimut.FullRowSelect = true;
            this.lvAzimut.GridLines = true;
            this.lvAzimut.HideSelection = false;
            this.lvAzimut.Location = new System.Drawing.Point(3, 16);
            this.lvAzimut.MultiSelect = false;
            this.lvAzimut.Name = "lvAzimut";
            this.lvAzimut.Size = new System.Drawing.Size(433, 465);
            this.lvAzimut.TabIndex = 0;
            this.lvAzimut.UseCompatibleStateImageBehavior = false;
            this.lvAzimut.View = System.Windows.Forms.View.Details;
            this.lvAzimut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAzimut_MouseDown);
            // 
            // AzimutKontrola
            // 
            this.AzimutKontrola.Text = "Kontrola";
            // 
            // AzimutStajaliste
            // 
            this.AzimutStajaliste.Text = "Stajalište";
            this.AzimutStajaliste.Width = 58;
            // 
            // AzimutVizura
            // 
            this.AzimutVizura.Text = "Vizura";
            this.AzimutVizura.Width = 58;
            // 
            // AzimutMjerene
            // 
            this.AzimutMjerene.Text = "Mjerenje";
            this.AzimutMjerene.Width = 54;
            // 
            // AzimutKoordinate
            // 
            this.AzimutKoordinate.Text = "Iz koord.";
            this.AzimutKoordinate.Width = 58;
            // 
            // AzimutF
            // 
            this.AzimutF.Text = "f";
            this.AzimutF.Width = 30;
            // 
            // AzimutiTezina
            // 
            this.AzimutiTezina.Text = "Tezina";
            this.AzimutiTezina.Width = 50;
            // 
            // AzimutSigma
            // 
            this.AzimutSigma.Text = "Sigma";
            this.AzimutSigma.Width = 51;
            // 
            // AzimutStDerivacijaY
            // 
            this.AzimutStDerivacijaY.Text = "y St. Derivacija";
            this.AzimutStDerivacijaY.Width = 120;
            // 
            // AzimutStDerivacijaX
            // 
            this.AzimutStDerivacijaX.Text = "x St. Derivacija";
            this.AzimutStDerivacijaX.Width = 120;
            // 
            // AzimutVzDerivacijaY
            // 
            this.AzimutVzDerivacijaY.Text = "y Vizura Derivacija";
            this.AzimutVzDerivacijaY.Width = 120;
            // 
            // AzimutVzDerivacijaX
            // 
            this.AzimutVzDerivacijaX.Text = "x Vizura Derivacija";
            this.AzimutVzDerivacijaX.Width = 120;
            // 
            // tpPravac
            // 
            this.tpPravac.Controls.Add(this.pnlPravac);
            this.tpPravac.Location = new System.Drawing.Point(4, 22);
            this.tpPravac.Name = "tpPravac";
            this.tpPravac.Padding = new System.Windows.Forms.Padding(3);
            this.tpPravac.Size = new System.Drawing.Size(693, 490);
            this.tpPravac.TabIndex = 2;
            this.tpPravac.Text = "Pravac";
            this.tpPravac.UseVisualStyleBackColor = true;
            // 
            // pnlPravac
            // 
            this.pnlPravac.Controls.Add(this.splitContainer4);
            this.pnlPravac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPravac.Location = new System.Drawing.Point(3, 3);
            this.pnlPravac.Name = "pnlPravac";
            this.pnlPravac.Size = new System.Drawing.Size(687, 484);
            this.pnlPravac.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.rtbPravci2dOpis);
            this.splitContainer4.Panel1.Controls.Add(this.gb2dMjerenjePravci);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gb2dPravciMjerenja);
            this.splitContainer4.Size = new System.Drawing.Size(687, 484);
            this.splitContainer4.SplitterDistance = 243;
            this.splitContainer4.TabIndex = 0;
            // 
            // rtbPravci2dOpis
            // 
            this.rtbPravci2dOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPravci2dOpis.Location = new System.Drawing.Point(3, 300);
            this.rtbPravci2dOpis.Name = "rtbPravci2dOpis";
            this.rtbPravci2dOpis.Size = new System.Drawing.Size(236, 181);
            this.rtbPravci2dOpis.TabIndex = 5;
            this.rtbPravci2dOpis.Text = "";
            // 
            // gb2dMjerenjePravci
            // 
            this.gb2dMjerenjePravci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciTolerancija);
            this.gb2dMjerenjePravci.Controls.Add(this.tb2dPravciTolarancijaZ);
            this.gb2dMjerenjePravci.Controls.Add(this.gb2dPravciTezine);
            this.gb2dMjerenjePravci.Controls.Add(this.btn2dDodajPravac);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciSekunde);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciMinute);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciST);
            this.gb2dMjerenjePravci.Controls.Add(this.tb2dPravciSekunde);
            this.gb2dMjerenjePravci.Controls.Add(this.tb2dPravciMinute);
            this.gb2dMjerenjePravci.Controls.Add(this.tb2dPravciStupnjevi);
            this.gb2dMjerenjePravci.Controls.Add(this.cmb2dPravciVizura);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciMjerenje);
            this.gb2dMjerenjePravci.Controls.Add(this.cmb2DpravciStajaliste);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciVizura);
            this.gb2dMjerenjePravci.Controls.Add(this.lbl2dPravciStajaliste);
            this.gb2dMjerenjePravci.Location = new System.Drawing.Point(3, 9);
            this.gb2dMjerenjePravci.Name = "gb2dMjerenjePravci";
            this.gb2dMjerenjePravci.Size = new System.Drawing.Size(236, 285);
            this.gb2dMjerenjePravci.TabIndex = 3;
            this.gb2dMjerenjePravci.TabStop = false;
            this.gb2dMjerenjePravci.Text = "Mjerenje";
            // 
            // lbl2dPravciTolerancija
            // 
            this.lbl2dPravciTolerancija.AutoSize = true;
            this.lbl2dPravciTolerancija.Location = new System.Drawing.Point(6, 222);
            this.lbl2dPravciTolerancija.Name = "lbl2dPravciTolerancija";
            this.lbl2dPravciTolerancija.Size = new System.Drawing.Size(190, 13);
            this.lbl2dPravciTolerancija.TabIndex = 12;
            this.lbl2dPravciTolerancija.Text = "Tolerancija odstupanja orijentacije Z [\'\']";
            // 
            // tb2dPravciTolarancijaZ
            // 
            this.tb2dPravciTolarancijaZ.Location = new System.Drawing.Point(202, 219);
            this.tb2dPravciTolarancijaZ.Name = "tb2dPravciTolarancijaZ";
            this.tb2dPravciTolarancijaZ.Size = new System.Drawing.Size(23, 20);
            this.tb2dPravciTolarancijaZ.TabIndex = 11;
            this.tb2dPravciTolarancijaZ.Text = "5";
            this.tb2dPravciTolarancijaZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciTolarancijaZ_KeyPress);
            // 
            // gb2dPravciTezine
            // 
            this.gb2dPravciTezine.Controls.Add(this.lbl2dPravciSigmaBrojGirusa);
            this.gb2dPravciTezine.Controls.Add(this.tb2dPravciSigmaBrojGirusa);
            this.gb2dPravciTezine.Controls.Add(this.label1);
            this.gb2dPravciTezine.Controls.Add(this.tb2dPravciTezina);
            this.gb2dPravciTezine.Controls.Add(this.tb2dPravciSigma);
            this.gb2dPravciTezine.Controls.Add(this.rb2dPravciTezina);
            this.gb2dPravciTezine.Controls.Add(this.rb2dPravciSigma);
            this.gb2dPravciTezine.Location = new System.Drawing.Point(9, 100);
            this.gb2dPravciTezine.Name = "gb2dPravciTezine";
            this.gb2dPravciTezine.Size = new System.Drawing.Size(216, 106);
            this.gb2dPravciTezine.TabIndex = 10;
            this.gb2dPravciTezine.TabStop = false;
            this.gb2dPravciTezine.Text = "Težina";
            // 
            // lbl2dPravciSigmaBrojGirusa
            // 
            this.lbl2dPravciSigmaBrojGirusa.AutoSize = true;
            this.lbl2dPravciSigmaBrojGirusa.Location = new System.Drawing.Point(11, 47);
            this.lbl2dPravciSigmaBrojGirusa.Name = "lbl2dPravciSigmaBrojGirusa";
            this.lbl2dPravciSigmaBrojGirusa.Size = new System.Drawing.Size(59, 13);
            this.lbl2dPravciSigmaBrojGirusa.TabIndex = 13;
            this.lbl2dPravciSigmaBrojGirusa.Text = "Broj girusa:";
            // 
            // tb2dPravciSigmaBrojGirusa
            // 
            this.tb2dPravciSigmaBrojGirusa.Location = new System.Drawing.Point(76, 44);
            this.tb2dPravciSigmaBrojGirusa.MaxLength = 6;
            this.tb2dPravciSigmaBrojGirusa.Name = "tb2dPravciSigmaBrojGirusa";
            this.tb2dPravciSigmaBrojGirusa.Size = new System.Drawing.Size(69, 20);
            this.tb2dPravciSigmaBrojGirusa.TabIndex = 13;
            this.tb2dPravciSigmaBrojGirusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciSigmaBrojGirusa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "\'\'";
            // 
            // tb2dPravciTezina
            // 
            this.tb2dPravciTezina.Enabled = false;
            this.tb2dPravciTezina.Location = new System.Drawing.Point(76, 70);
            this.tb2dPravciTezina.MaxLength = 6;
            this.tb2dPravciTezina.Name = "tb2dPravciTezina";
            this.tb2dPravciTezina.Size = new System.Drawing.Size(69, 20);
            this.tb2dPravciTezina.TabIndex = 12;
            this.tb2dPravciTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciTezina_KeyPress);
            // 
            // tb2dPravciSigma
            // 
            this.tb2dPravciSigma.Location = new System.Drawing.Point(76, 18);
            this.tb2dPravciSigma.MaxLength = 6;
            this.tb2dPravciSigma.Name = "tb2dPravciSigma";
            this.tb2dPravciSigma.Size = new System.Drawing.Size(69, 20);
            this.tb2dPravciSigma.TabIndex = 11;
            this.tb2dPravciSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciSigma_KeyPress);
            // 
            // rb2dPravciTezina
            // 
            this.rb2dPravciTezina.AutoSize = true;
            this.rb2dPravciTezina.Location = new System.Drawing.Point(13, 71);
            this.rb2dPravciTezina.Name = "rb2dPravciTezina";
            this.rb2dPravciTezina.Size = new System.Drawing.Size(60, 17);
            this.rb2dPravciTezina.TabIndex = 1;
            this.rb2dPravciTezina.Text = "Težina:";
            this.rb2dPravciTezina.UseVisualStyleBackColor = true;
            this.rb2dPravciTezina.CheckedChanged += new System.EventHandler(this.rb2dPravciTezina_CheckedChanged);
            // 
            // rb2dPravciSigma
            // 
            this.rb2dPravciSigma.AutoSize = true;
            this.rb2dPravciSigma.Checked = true;
            this.rb2dPravciSigma.Location = new System.Drawing.Point(13, 19);
            this.rb2dPravciSigma.Name = "rb2dPravciSigma";
            this.rb2dPravciSigma.Size = new System.Drawing.Size(57, 17);
            this.rb2dPravciSigma.TabIndex = 0;
            this.rb2dPravciSigma.TabStop = true;
            this.rb2dPravciSigma.Text = "Sigma:";
            this.rb2dPravciSigma.UseVisualStyleBackColor = true;
            this.rb2dPravciSigma.CheckedChanged += new System.EventHandler(this.rb2dPravciSigma_CheckedChanged);
            // 
            // btn2dDodajPravac
            // 
            this.btn2dDodajPravac.Location = new System.Drawing.Point(150, 252);
            this.btn2dDodajPravac.Name = "btn2dDodajPravac";
            this.btn2dDodajPravac.Size = new System.Drawing.Size(75, 23);
            this.btn2dDodajPravac.TabIndex = 9;
            this.btn2dDodajPravac.Text = "Dodaj";
            this.btn2dDodajPravac.UseVisualStyleBackColor = true;
            this.btn2dDodajPravac.Click += new System.EventHandler(this.btn2dDodajPravac_Click);
            // 
            // lbl2dPravciSekunde
            // 
            this.lbl2dPravciSekunde.AutoSize = true;
            this.lbl2dPravciSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dPravciSekunde.Location = new System.Drawing.Point(212, 74);
            this.lbl2dPravciSekunde.Name = "lbl2dPravciSekunde";
            this.lbl2dPravciSekunde.Size = new System.Drawing.Size(13, 15);
            this.lbl2dPravciSekunde.TabIndex = 8;
            this.lbl2dPravciSekunde.Text = "\'\'";
            // 
            // lbl2dPravciMinute
            // 
            this.lbl2dPravciMinute.AutoSize = true;
            this.lbl2dPravciMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dPravciMinute.Location = new System.Drawing.Point(144, 74);
            this.lbl2dPravciMinute.Name = "lbl2dPravciMinute";
            this.lbl2dPravciMinute.Size = new System.Drawing.Size(10, 15);
            this.lbl2dPravciMinute.TabIndex = 7;
            this.lbl2dPravciMinute.Text = "\'";
            // 
            // lbl2dPravciST
            // 
            this.lbl2dPravciST.AutoSize = true;
            this.lbl2dPravciST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dPravciST.Location = new System.Drawing.Point(94, 75);
            this.lbl2dPravciST.Name = "lbl2dPravciST";
            this.lbl2dPravciST.Size = new System.Drawing.Size(12, 15);
            this.lbl2dPravciST.TabIndex = 6;
            this.lbl2dPravciST.Text = "°";
            // 
            // tb2dPravciSekunde
            // 
            this.tb2dPravciSekunde.Location = new System.Drawing.Point(162, 73);
            this.tb2dPravciSekunde.MaxLength = 6;
            this.tb2dPravciSekunde.Name = "tb2dPravciSekunde";
            this.tb2dPravciSekunde.Size = new System.Drawing.Size(44, 20);
            this.tb2dPravciSekunde.TabIndex = 5;
            this.tb2dPravciSekunde.TextChanged += new System.EventHandler(this.tb2dPravciSekunde_TextChanged);
            this.tb2dPravciSekunde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciSekunde_KeyPress);
            // 
            // tb2dPravciMinute
            // 
            this.tb2dPravciMinute.Location = new System.Drawing.Point(112, 74);
            this.tb2dPravciMinute.MaxLength = 2;
            this.tb2dPravciMinute.Name = "tb2dPravciMinute";
            this.tb2dPravciMinute.Size = new System.Drawing.Size(26, 20);
            this.tb2dPravciMinute.TabIndex = 4;
            this.tb2dPravciMinute.TextChanged += new System.EventHandler(this.tb2dPravciMinute_TextChanged);
            this.tb2dPravciMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciMinute_KeyPress);
            // 
            // tb2dPravciStupnjevi
            // 
            this.tb2dPravciStupnjevi.Location = new System.Drawing.Point(63, 74);
            this.tb2dPravciStupnjevi.MaxLength = 3;
            this.tb2dPravciStupnjevi.Name = "tb2dPravciStupnjevi";
            this.tb2dPravciStupnjevi.Size = new System.Drawing.Size(28, 20);
            this.tb2dPravciStupnjevi.TabIndex = 3;
            this.tb2dPravciStupnjevi.TextChanged += new System.EventHandler(this.tb2dPravciStupnjevi_TextChanged);
            this.tb2dPravciStupnjevi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dPravciStupnjevi_KeyPress);
            // 
            // cmb2dPravciVizura
            // 
            this.cmb2dPravciVizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2dPravciVizura.FormattingEnabled = true;
            this.cmb2dPravciVizura.Location = new System.Drawing.Point(63, 47);
            this.cmb2dPravciVizura.Name = "cmb2dPravciVizura";
            this.cmb2dPravciVizura.Size = new System.Drawing.Size(162, 21);
            this.cmb2dPravciVizura.TabIndex = 1;
            // 
            // lbl2dPravciMjerenje
            // 
            this.lbl2dPravciMjerenje.AutoSize = true;
            this.lbl2dPravciMjerenje.Location = new System.Drawing.Point(6, 77);
            this.lbl2dPravciMjerenje.Name = "lbl2dPravciMjerenje";
            this.lbl2dPravciMjerenje.Size = new System.Drawing.Size(50, 13);
            this.lbl2dPravciMjerenje.TabIndex = 2;
            this.lbl2dPravciMjerenje.Text = "Mjerenje:";
            // 
            // cmb2DpravciStajaliste
            // 
            this.cmb2DpravciStajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DpravciStajaliste.FormattingEnabled = true;
            this.cmb2DpravciStajaliste.Location = new System.Drawing.Point(63, 20);
            this.cmb2DpravciStajaliste.Name = "cmb2DpravciStajaliste";
            this.cmb2DpravciStajaliste.Size = new System.Drawing.Size(162, 21);
            this.cmb2DpravciStajaliste.TabIndex = 0;
            this.cmb2DpravciStajaliste.SelectedIndexChanged += new System.EventHandler(this.cmb2DpravciStajaliste_SelectedIndexChanged);
            // 
            // lbl2dPravciVizura
            // 
            this.lbl2dPravciVizura.AutoSize = true;
            this.lbl2dPravciVizura.Location = new System.Drawing.Point(19, 50);
            this.lbl2dPravciVizura.Name = "lbl2dPravciVizura";
            this.lbl2dPravciVizura.Size = new System.Drawing.Size(39, 13);
            this.lbl2dPravciVizura.TabIndex = 1;
            this.lbl2dPravciVizura.Text = "Vizura:";
            // 
            // lbl2dPravciStajaliste
            // 
            this.lbl2dPravciStajaliste.AutoSize = true;
            this.lbl2dPravciStajaliste.Location = new System.Drawing.Point(6, 23);
            this.lbl2dPravciStajaliste.Name = "lbl2dPravciStajaliste";
            this.lbl2dPravciStajaliste.Size = new System.Drawing.Size(52, 13);
            this.lbl2dPravciStajaliste.TabIndex = 0;
            this.lbl2dPravciStajaliste.Text = "Stajalište:";
            // 
            // gb2dPravciMjerenja
            // 
            this.gb2dPravciMjerenja.Controls.Add(this.lvPravac);
            this.gb2dPravciMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb2dPravciMjerenja.Location = new System.Drawing.Point(0, 0);
            this.gb2dPravciMjerenja.Name = "gb2dPravciMjerenja";
            this.gb2dPravciMjerenja.Size = new System.Drawing.Size(440, 484);
            this.gb2dPravciMjerenja.TabIndex = 1;
            this.gb2dPravciMjerenja.TabStop = false;
            this.gb2dPravciMjerenja.Text = "Mjerenja";
            // 
            // lvPravac
            // 
            this.lvPravac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PravciZkontrola,
            this.PravciStajaliste,
            this.PravciVizura,
            this.PravciMjerenje,
            this.PravciSmjerni,
            this.PravciZ,
            this.PravciZsrednje,
            this.PravciF,
            this.PravciTezina,
            this.PravciSigma,
            this.PravciStajalisteDerivacijaY,
            this.PravciStajalisteDerivacijaX,
            this.PravciVizuraDerivacijaY,
            this.PravciVizuraDerivacijaX});
            this.lvPravac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPravac.FullRowSelect = true;
            this.lvPravac.GridLines = true;
            this.lvPravac.HideSelection = false;
            this.lvPravac.Location = new System.Drawing.Point(3, 16);
            this.lvPravac.MultiSelect = false;
            this.lvPravac.Name = "lvPravac";
            this.lvPravac.Size = new System.Drawing.Size(434, 465);
            this.lvPravac.TabIndex = 0;
            this.lvPravac.UseCompatibleStateImageBehavior = false;
            this.lvPravac.View = System.Windows.Forms.View.Details;
            this.lvPravac.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvPravac_MouseDown);
            // 
            // PravciZkontrola
            // 
            this.PravciZkontrola.Text = "Kontrola";
            // 
            // PravciStajaliste
            // 
            this.PravciStajaliste.Text = "Stajalište";
            this.PravciStajaliste.Width = 58;
            // 
            // PravciVizura
            // 
            this.PravciVizura.Text = "Vizura";
            this.PravciVizura.Width = 58;
            // 
            // PravciMjerenje
            // 
            this.PravciMjerenje.Text = "Mjerenje";
            this.PravciMjerenje.Width = 57;
            // 
            // PravciSmjerni
            // 
            this.PravciSmjerni.Text = "Ni";
            // 
            // PravciZ
            // 
            this.PravciZ.Text = "Z";
            this.PravciZ.Width = 25;
            // 
            // PravciZsrednje
            // 
            this.PravciZsrednje.Text = "Z srednje";
            this.PravciZsrednje.Width = 65;
            // 
            // PravciF
            // 
            this.PravciF.Text = "f";
            this.PravciF.Width = 33;
            // 
            // PravciTezina
            // 
            this.PravciTezina.Text = "Težina";
            this.PravciTezina.Width = 50;
            // 
            // PravciSigma
            // 
            this.PravciSigma.Text = "Sigma";
            this.PravciSigma.Width = 50;
            // 
            // PravciStajalisteDerivacijaY
            // 
            this.PravciStajalisteDerivacijaY.Text = "y St. Derivacija";
            this.PravciStajalisteDerivacijaY.Width = 120;
            // 
            // PravciStajalisteDerivacijaX
            // 
            this.PravciStajalisteDerivacijaX.Text = "x St. Derivacija";
            this.PravciStajalisteDerivacijaX.Width = 120;
            // 
            // PravciVizuraDerivacijaY
            // 
            this.PravciVizuraDerivacijaY.Text = "y Vizura Derivacija";
            this.PravciVizuraDerivacijaY.Width = 120;
            // 
            // PravciVizuraDerivacijaX
            // 
            this.PravciVizuraDerivacijaX.Text = "x Vizura Derivacija";
            this.PravciVizuraDerivacijaX.Width = 120;
            // 
            // tpKut
            // 
            this.tpKut.Controls.Add(this.pnlKut);
            this.tpKut.Location = new System.Drawing.Point(4, 22);
            this.tpKut.Name = "tpKut";
            this.tpKut.Padding = new System.Windows.Forms.Padding(3);
            this.tpKut.Size = new System.Drawing.Size(693, 490);
            this.tpKut.TabIndex = 3;
            this.tpKut.Text = "Kut (ugao)";
            this.tpKut.UseVisualStyleBackColor = true;
            // 
            // pnlKut
            // 
            this.pnlKut.Controls.Add(this.splitContainer5);
            this.pnlKut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKut.Location = new System.Drawing.Point(3, 3);
            this.pnlKut.Name = "pnlKut";
            this.pnlKut.Size = new System.Drawing.Size(687, 484);
            this.pnlKut.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.rtbKutOpis);
            this.splitContainer5.Panel1.Controls.Add(this.gb2dKuteviMjerenje);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.gb2dKuteviMjerenja);
            this.splitContainer5.Size = new System.Drawing.Size(687, 484);
            this.splitContainer5.SplitterDistance = 242;
            this.splitContainer5.TabIndex = 0;
            // 
            // rtbKutOpis
            // 
            this.rtbKutOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbKutOpis.Location = new System.Drawing.Point(3, 362);
            this.rtbKutOpis.Name = "rtbKutOpis";
            this.rtbKutOpis.Size = new System.Drawing.Size(236, 122);
            this.rtbKutOpis.TabIndex = 6;
            this.rtbKutOpis.Text = "";
            // 
            // gb2dKuteviMjerenje
            // 
            this.gb2dKuteviMjerenje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2dKuteviMjerenje.Controls.Add(this.cmb2DkuteviDO);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviDo);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviTolerancija);
            this.gb2dKuteviMjerenje.Controls.Add(this.tb2dKuteviTolerancija);
            this.gb2dKuteviMjerenje.Controls.Add(this.gb2dKuteviTezina);
            this.gb2dKuteviMjerenje.Controls.Add(this.btn2dKuteviDodaj);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviMjerenjeSekunde);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviMjerenjeMinute);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviMjerenjeStupnjevi);
            this.gb2dKuteviMjerenje.Controls.Add(this.tb2dKuteviSekunde);
            this.gb2dKuteviMjerenje.Controls.Add(this.tb2dKuteviMinute);
            this.gb2dKuteviMjerenje.Controls.Add(this.tb2dKuteviStupnjevi);
            this.gb2dKuteviMjerenje.Controls.Add(this.cmb2DkuteviOD);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviMjerenje);
            this.gb2dKuteviMjerenje.Controls.Add(this.cmb2DkuteviStajaliste);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviOd);
            this.gb2dKuteviMjerenje.Controls.Add(this.lbl2dKuteviStajaliste);
            this.gb2dKuteviMjerenje.Location = new System.Drawing.Point(3, 9);
            this.gb2dKuteviMjerenje.Name = "gb2dKuteviMjerenje";
            this.gb2dKuteviMjerenje.Size = new System.Drawing.Size(236, 347);
            this.gb2dKuteviMjerenje.TabIndex = 3;
            this.gb2dKuteviMjerenje.TabStop = false;
            this.gb2dKuteviMjerenje.Text = "Mjerenje";
            // 
            // cmb2DkuteviDO
            // 
            this.cmb2DkuteviDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DkuteviDO.FormattingEnabled = true;
            this.cmb2DkuteviDO.Location = new System.Drawing.Point(65, 74);
            this.cmb2DkuteviDO.Name = "cmb2DkuteviDO";
            this.cmb2DkuteviDO.Size = new System.Drawing.Size(162, 21);
            this.cmb2DkuteviDO.TabIndex = 14;
            // 
            // lbl2dKuteviDo
            // 
            this.lbl2dKuteviDo.AutoSize = true;
            this.lbl2dKuteviDo.Location = new System.Drawing.Point(34, 77);
            this.lbl2dKuteviDo.Name = "lbl2dKuteviDo";
            this.lbl2dKuteviDo.Size = new System.Drawing.Size(24, 13);
            this.lbl2dKuteviDo.TabIndex = 13;
            this.lbl2dKuteviDo.Text = "Do:";
            // 
            // lbl2dKuteviTolerancija
            // 
            this.lbl2dKuteviTolerancija.AutoSize = true;
            this.lbl2dKuteviTolerancija.Location = new System.Drawing.Point(5, 286);
            this.lbl2dKuteviTolerancija.Name = "lbl2dKuteviTolerancija";
            this.lbl2dKuteviTolerancija.Size = new System.Drawing.Size(151, 13);
            this.lbl2dKuteviTolerancija.TabIndex = 12;
            this.lbl2dKuteviTolerancija.Text = "Tolerancija odstupanja kuta [\'\']";
            // 
            // tb2dKuteviTolerancija
            // 
            this.tb2dKuteviTolerancija.Location = new System.Drawing.Point(157, 283);
            this.tb2dKuteviTolerancija.Name = "tb2dKuteviTolerancija";
            this.tb2dKuteviTolerancija.Size = new System.Drawing.Size(23, 20);
            this.tb2dKuteviTolerancija.TabIndex = 11;
            this.tb2dKuteviTolerancija.Text = "5";
            this.tb2dKuteviTolerancija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviTolerancija_KeyPress);
            // 
            // gb2dKuteviTezina
            // 
            this.gb2dKuteviTezina.Controls.Add(this.tbKutTezina);
            this.gb2dKuteviTezina.Controls.Add(this.lbl2dKuteviSigmaBrojGirusa);
            this.gb2dKuteviTezina.Controls.Add(this.tbKutSigmaBrojGirusa);
            this.gb2dKuteviTezina.Controls.Add(this.lbl2dKuteviSigmaKutaSekunde);
            this.gb2dKuteviTezina.Controls.Add(this.tb2dKuteviSigmaKut);
            this.gb2dKuteviTezina.Controls.Add(this.rb2dKuteviSigmaKuta);
            this.gb2dKuteviTezina.Controls.Add(this.lblKuteviSigmaPravacSekunde);
            this.gb2dKuteviTezina.Controls.Add(this.tb2dKuteviSigmaPravac);
            this.gb2dKuteviTezina.Controls.Add(this.rb2dKuteviTezina);
            this.gb2dKuteviTezina.Controls.Add(this.rb2dKuteviSigmaPravac);
            this.gb2dKuteviTezina.Location = new System.Drawing.Point(11, 131);
            this.gb2dKuteviTezina.Name = "gb2dKuteviTezina";
            this.gb2dKuteviTezina.Size = new System.Drawing.Size(216, 131);
            this.gb2dKuteviTezina.TabIndex = 10;
            this.gb2dKuteviTezina.TabStop = false;
            this.gb2dKuteviTezina.Text = "Težina";
            // 
            // tbKutTezina
            // 
            this.tbKutTezina.Enabled = false;
            this.tbKutTezina.Location = new System.Drawing.Point(103, 96);
            this.tbKutTezina.MaxLength = 6;
            this.tbKutTezina.Name = "tbKutTezina";
            this.tbKutTezina.Size = new System.Drawing.Size(69, 20);
            this.tbKutTezina.TabIndex = 17;
            // 
            // lbl2dKuteviSigmaBrojGirusa
            // 
            this.lbl2dKuteviSigmaBrojGirusa.AutoSize = true;
            this.lbl2dKuteviSigmaBrojGirusa.Location = new System.Drawing.Point(38, 47);
            this.lbl2dKuteviSigmaBrojGirusa.Name = "lbl2dKuteviSigmaBrojGirusa";
            this.lbl2dKuteviSigmaBrojGirusa.Size = new System.Drawing.Size(59, 13);
            this.lbl2dKuteviSigmaBrojGirusa.TabIndex = 14;
            this.lbl2dKuteviSigmaBrojGirusa.Text = "Broj girusa:";
            // 
            // tbKutSigmaBrojGirusa
            // 
            this.tbKutSigmaBrojGirusa.Location = new System.Drawing.Point(103, 44);
            this.tbKutSigmaBrojGirusa.MaxLength = 6;
            this.tbKutSigmaBrojGirusa.Name = "tbKutSigmaBrojGirusa";
            this.tbKutSigmaBrojGirusa.Size = new System.Drawing.Size(69, 20);
            this.tbKutSigmaBrojGirusa.TabIndex = 16;
            this.tbKutSigmaBrojGirusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviSigmaBrojGirusa_KeyPress);
            // 
            // lbl2dKuteviSigmaKutaSekunde
            // 
            this.lbl2dKuteviSigmaKutaSekunde.AutoSize = true;
            this.lbl2dKuteviSigmaKutaSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dKuteviSigmaKutaSekunde.Location = new System.Drawing.Point(177, 68);
            this.lbl2dKuteviSigmaKutaSekunde.Name = "lbl2dKuteviSigmaKutaSekunde";
            this.lbl2dKuteviSigmaKutaSekunde.Size = new System.Drawing.Size(13, 15);
            this.lbl2dKuteviSigmaKutaSekunde.TabIndex = 14;
            this.lbl2dKuteviSigmaKutaSekunde.Text = "\'\'";
            // 
            // tb2dKuteviSigmaKut
            // 
            this.tb2dKuteviSigmaKut.Enabled = false;
            this.tb2dKuteviSigmaKut.Location = new System.Drawing.Point(103, 70);
            this.tb2dKuteviSigmaKut.MaxLength = 6;
            this.tb2dKuteviSigmaKut.Name = "tb2dKuteviSigmaKut";
            this.tb2dKuteviSigmaKut.Size = new System.Drawing.Size(69, 20);
            this.tb2dKuteviSigmaKut.TabIndex = 15;
            this.tb2dKuteviSigmaKut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviSigmaKut_KeyPress);
            // 
            // rb2dKuteviSigmaKuta
            // 
            this.rb2dKuteviSigmaKuta.AutoSize = true;
            this.rb2dKuteviSigmaKuta.Location = new System.Drawing.Point(13, 71);
            this.rb2dKuteviSigmaKuta.Name = "rb2dKuteviSigmaKuta";
            this.rb2dKuteviSigmaKuta.Size = new System.Drawing.Size(81, 17);
            this.rb2dKuteviSigmaKuta.TabIndex = 13;
            this.rb2dKuteviSigmaKuta.Text = "Sigma kuta:";
            this.rb2dKuteviSigmaKuta.UseVisualStyleBackColor = true;
            this.rb2dKuteviSigmaKuta.CheckedChanged += new System.EventHandler(this.rb2dKuteviSigmaKuta_CheckedChanged);
            // 
            // lblKuteviSigmaPravacSekunde
            // 
            this.lblKuteviSigmaPravacSekunde.AutoSize = true;
            this.lblKuteviSigmaPravacSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuteviSigmaPravacSekunde.Location = new System.Drawing.Point(177, 16);
            this.lblKuteviSigmaPravacSekunde.Name = "lblKuteviSigmaPravacSekunde";
            this.lblKuteviSigmaPravacSekunde.Size = new System.Drawing.Size(13, 15);
            this.lblKuteviSigmaPravacSekunde.TabIndex = 11;
            this.lblKuteviSigmaPravacSekunde.Text = "\'\'";
            // 
            // tb2dKuteviSigmaPravac
            // 
            this.tb2dKuteviSigmaPravac.Location = new System.Drawing.Point(103, 18);
            this.tb2dKuteviSigmaPravac.MaxLength = 6;
            this.tb2dKuteviSigmaPravac.Name = "tb2dKuteviSigmaPravac";
            this.tb2dKuteviSigmaPravac.Size = new System.Drawing.Size(69, 20);
            this.tb2dKuteviSigmaPravac.TabIndex = 11;
            this.tb2dKuteviSigmaPravac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviSigmaPravac_KeyPress);
            // 
            // rb2dKuteviTezina
            // 
            this.rb2dKuteviTezina.AutoSize = true;
            this.rb2dKuteviTezina.Location = new System.Drawing.Point(13, 97);
            this.rb2dKuteviTezina.Name = "rb2dKuteviTezina";
            this.rb2dKuteviTezina.Size = new System.Drawing.Size(60, 17);
            this.rb2dKuteviTezina.TabIndex = 1;
            this.rb2dKuteviTezina.Text = "Težina:";
            this.rb2dKuteviTezina.UseVisualStyleBackColor = true;
            this.rb2dKuteviTezina.CheckedChanged += new System.EventHandler(this.rb2dKuteviTezina_CheckedChanged);
            // 
            // rb2dKuteviSigmaPravac
            // 
            this.rb2dKuteviSigmaPravac.AutoSize = true;
            this.rb2dKuteviSigmaPravac.Checked = true;
            this.rb2dKuteviSigmaPravac.Location = new System.Drawing.Point(13, 19);
            this.rb2dKuteviSigmaPravac.Name = "rb2dKuteviSigmaPravac";
            this.rb2dKuteviSigmaPravac.Size = new System.Drawing.Size(93, 17);
            this.rb2dKuteviSigmaPravac.TabIndex = 0;
            this.rb2dKuteviSigmaPravac.TabStop = true;
            this.rb2dKuteviSigmaPravac.Text = "Sigma pravac:";
            this.rb2dKuteviSigmaPravac.UseVisualStyleBackColor = true;
            this.rb2dKuteviSigmaPravac.CheckedChanged += new System.EventHandler(this.rb2dKuteviSigmaPravac_CheckedChanged);
            // 
            // btn2dKuteviDodaj
            // 
            this.btn2dKuteviDodaj.Location = new System.Drawing.Point(152, 314);
            this.btn2dKuteviDodaj.Name = "btn2dKuteviDodaj";
            this.btn2dKuteviDodaj.Size = new System.Drawing.Size(75, 23);
            this.btn2dKuteviDodaj.TabIndex = 9;
            this.btn2dKuteviDodaj.Text = "Dodaj";
            this.btn2dKuteviDodaj.UseVisualStyleBackColor = true;
            this.btn2dKuteviDodaj.Click += new System.EventHandler(this.btn2dKuteviDodaj_Click);
            // 
            // lbl2dKuteviMjerenjeSekunde
            // 
            this.lbl2dKuteviMjerenjeSekunde.AutoSize = true;
            this.lbl2dKuteviMjerenjeSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dKuteviMjerenjeSekunde.Location = new System.Drawing.Point(214, 102);
            this.lbl2dKuteviMjerenjeSekunde.Name = "lbl2dKuteviMjerenjeSekunde";
            this.lbl2dKuteviMjerenjeSekunde.Size = new System.Drawing.Size(13, 15);
            this.lbl2dKuteviMjerenjeSekunde.TabIndex = 8;
            this.lbl2dKuteviMjerenjeSekunde.Text = "\'\'";
            // 
            // lbl2dKuteviMjerenjeMinute
            // 
            this.lbl2dKuteviMjerenjeMinute.AutoSize = true;
            this.lbl2dKuteviMjerenjeMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dKuteviMjerenjeMinute.Location = new System.Drawing.Point(146, 102);
            this.lbl2dKuteviMjerenjeMinute.Name = "lbl2dKuteviMjerenjeMinute";
            this.lbl2dKuteviMjerenjeMinute.Size = new System.Drawing.Size(10, 15);
            this.lbl2dKuteviMjerenjeMinute.TabIndex = 7;
            this.lbl2dKuteviMjerenjeMinute.Text = "\'";
            // 
            // lbl2dKuteviMjerenjeStupnjevi
            // 
            this.lbl2dKuteviMjerenjeStupnjevi.AutoSize = true;
            this.lbl2dKuteviMjerenjeStupnjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dKuteviMjerenjeStupnjevi.Location = new System.Drawing.Point(96, 103);
            this.lbl2dKuteviMjerenjeStupnjevi.Name = "lbl2dKuteviMjerenjeStupnjevi";
            this.lbl2dKuteviMjerenjeStupnjevi.Size = new System.Drawing.Size(12, 15);
            this.lbl2dKuteviMjerenjeStupnjevi.TabIndex = 6;
            this.lbl2dKuteviMjerenjeStupnjevi.Text = "°";
            // 
            // tb2dKuteviSekunde
            // 
            this.tb2dKuteviSekunde.Location = new System.Drawing.Point(164, 101);
            this.tb2dKuteviSekunde.MaxLength = 6;
            this.tb2dKuteviSekunde.Name = "tb2dKuteviSekunde";
            this.tb2dKuteviSekunde.Size = new System.Drawing.Size(44, 20);
            this.tb2dKuteviSekunde.TabIndex = 5;
            this.tb2dKuteviSekunde.TextChanged += new System.EventHandler(this.tb2dKuteviSekunde_TextChanged);
            this.tb2dKuteviSekunde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviSekunde_KeyPress);
            // 
            // tb2dKuteviMinute
            // 
            this.tb2dKuteviMinute.Location = new System.Drawing.Point(114, 102);
            this.tb2dKuteviMinute.MaxLength = 2;
            this.tb2dKuteviMinute.Name = "tb2dKuteviMinute";
            this.tb2dKuteviMinute.Size = new System.Drawing.Size(26, 20);
            this.tb2dKuteviMinute.TabIndex = 4;
            this.tb2dKuteviMinute.TextChanged += new System.EventHandler(this.tb2dKuteviMinute_TextChanged);
            this.tb2dKuteviMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviMinute_KeyPress);
            // 
            // tb2dKuteviStupnjevi
            // 
            this.tb2dKuteviStupnjevi.Location = new System.Drawing.Point(65, 102);
            this.tb2dKuteviStupnjevi.MaxLength = 3;
            this.tb2dKuteviStupnjevi.Name = "tb2dKuteviStupnjevi";
            this.tb2dKuteviStupnjevi.Size = new System.Drawing.Size(28, 20);
            this.tb2dKuteviStupnjevi.TabIndex = 3;
            this.tb2dKuteviStupnjevi.TextChanged += new System.EventHandler(this.tb2dKuteviStupnjevi_TextChanged);
            this.tb2dKuteviStupnjevi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dKuteviStupnjevi_KeyPress);
            // 
            // cmb2DkuteviOD
            // 
            this.cmb2DkuteviOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DkuteviOD.FormattingEnabled = true;
            this.cmb2DkuteviOD.Location = new System.Drawing.Point(65, 47);
            this.cmb2DkuteviOD.Name = "cmb2DkuteviOD";
            this.cmb2DkuteviOD.Size = new System.Drawing.Size(162, 21);
            this.cmb2DkuteviOD.TabIndex = 1;
            this.cmb2DkuteviOD.SelectedIndexChanged += new System.EventHandler(this.cmb2DkuteviOD_SelectedIndexChanged);
            // 
            // lbl2dKuteviMjerenje
            // 
            this.lbl2dKuteviMjerenje.AutoSize = true;
            this.lbl2dKuteviMjerenje.Location = new System.Drawing.Point(8, 105);
            this.lbl2dKuteviMjerenje.Name = "lbl2dKuteviMjerenje";
            this.lbl2dKuteviMjerenje.Size = new System.Drawing.Size(50, 13);
            this.lbl2dKuteviMjerenje.TabIndex = 2;
            this.lbl2dKuteviMjerenje.Text = "Mjerenje:";
            // 
            // cmb2DkuteviStajaliste
            // 
            this.cmb2DkuteviStajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DkuteviStajaliste.FormattingEnabled = true;
            this.cmb2DkuteviStajaliste.Location = new System.Drawing.Point(65, 20);
            this.cmb2DkuteviStajaliste.Name = "cmb2DkuteviStajaliste";
            this.cmb2DkuteviStajaliste.Size = new System.Drawing.Size(162, 21);
            this.cmb2DkuteviStajaliste.TabIndex = 0;
            this.cmb2DkuteviStajaliste.SelectedIndexChanged += new System.EventHandler(this.cmb2DkuteviStajaliste_SelectedIndexChanged);
            // 
            // lbl2dKuteviOd
            // 
            this.lbl2dKuteviOd.AutoSize = true;
            this.lbl2dKuteviOd.Location = new System.Drawing.Point(34, 50);
            this.lbl2dKuteviOd.Name = "lbl2dKuteviOd";
            this.lbl2dKuteviOd.Size = new System.Drawing.Size(24, 13);
            this.lbl2dKuteviOd.TabIndex = 1;
            this.lbl2dKuteviOd.Text = "Od:";
            // 
            // lbl2dKuteviStajaliste
            // 
            this.lbl2dKuteviStajaliste.AutoSize = true;
            this.lbl2dKuteviStajaliste.Location = new System.Drawing.Point(6, 23);
            this.lbl2dKuteviStajaliste.Name = "lbl2dKuteviStajaliste";
            this.lbl2dKuteviStajaliste.Size = new System.Drawing.Size(52, 13);
            this.lbl2dKuteviStajaliste.TabIndex = 0;
            this.lbl2dKuteviStajaliste.Text = "Stajalište:";
            // 
            // gb2dKuteviMjerenja
            // 
            this.gb2dKuteviMjerenja.Controls.Add(this.lvKut);
            this.gb2dKuteviMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb2dKuteviMjerenja.Location = new System.Drawing.Point(0, 0);
            this.gb2dKuteviMjerenja.Name = "gb2dKuteviMjerenja";
            this.gb2dKuteviMjerenja.Size = new System.Drawing.Size(441, 484);
            this.gb2dKuteviMjerenja.TabIndex = 1;
            this.gb2dKuteviMjerenja.TabStop = false;
            this.gb2dKuteviMjerenja.Text = "Mjerenja";
            // 
            // lvKut
            // 
            this.lvKut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KuteviKontrola,
            this.KuteviStajaliste,
            this.KuteviOD,
            this.KuteviDO,
            this.KuteviMjerenje,
            this.KuteviKoordinate,
            this.KuteviF,
            this.KuteviTezina,
            this.KuteviSigmaKuta,
            this.KuteviStajalisteDerivacijaY,
            this.KuteviStajalisteDerivacijaX,
            this.KuteviOdDerivacijaY,
            this.KuteviOdDerivacijaX,
            this.KuteviDoDerivacijaY,
            this.KuteviDoDerivacijaX});
            this.lvKut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKut.FullRowSelect = true;
            this.lvKut.GridLines = true;
            this.lvKut.HideSelection = false;
            this.lvKut.Location = new System.Drawing.Point(3, 16);
            this.lvKut.MultiSelect = false;
            this.lvKut.Name = "lvKut";
            this.lvKut.Size = new System.Drawing.Size(435, 465);
            this.lvKut.TabIndex = 0;
            this.lvKut.UseCompatibleStateImageBehavior = false;
            this.lvKut.View = System.Windows.Forms.View.Details;
            this.lvKut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvKut_MouseDown);
            // 
            // KuteviKontrola
            // 
            this.KuteviKontrola.Text = "Kontrola";
            // 
            // KuteviStajaliste
            // 
            this.KuteviStajaliste.Text = "Stajalište";
            this.KuteviStajaliste.Width = 58;
            // 
            // KuteviOD
            // 
            this.KuteviOD.Text = "Od";
            this.KuteviOD.Width = 31;
            // 
            // KuteviDO
            // 
            this.KuteviDO.Text = "Do";
            this.KuteviDO.Width = 36;
            // 
            // KuteviMjerenje
            // 
            this.KuteviMjerenje.Text = "Mjerenje";
            this.KuteviMjerenje.Width = 56;
            // 
            // KuteviKoordinate
            // 
            this.KuteviKoordinate.Text = "Iz koord.";
            this.KuteviKoordinate.Width = 56;
            // 
            // KuteviF
            // 
            this.KuteviF.Text = "f";
            this.KuteviF.Width = 29;
            // 
            // KuteviTezina
            // 
            this.KuteviTezina.Text = "Tezina";
            this.KuteviTezina.Width = 50;
            // 
            // KuteviSigmaKuta
            // 
            this.KuteviSigmaKuta.Text = "Sigma kuta";
            this.KuteviSigmaKuta.Width = 30;
            // 
            // KuteviStajalisteDerivacijaY
            // 
            this.KuteviStajalisteDerivacijaY.Text = "y St Derivacija";
            this.KuteviStajalisteDerivacijaY.Width = 120;
            // 
            // KuteviStajalisteDerivacijaX
            // 
            this.KuteviStajalisteDerivacijaX.Text = "x St Derivacija";
            this.KuteviStajalisteDerivacijaX.Width = 120;
            // 
            // KuteviOdDerivacijaY
            // 
            this.KuteviOdDerivacijaY.Text = "y Od Derivacija";
            this.KuteviOdDerivacijaY.Width = 120;
            // 
            // KuteviOdDerivacijaX
            // 
            this.KuteviOdDerivacijaX.Text = "x Od Derivacija";
            this.KuteviOdDerivacijaX.Width = 120;
            // 
            // KuteviDoDerivacijaY
            // 
            this.KuteviDoDerivacijaY.Text = "y Do Derivacija";
            this.KuteviDoDerivacijaY.Width = 120;
            // 
            // KuteviDoDerivacijaX
            // 
            this.KuteviDoDerivacijaX.Text = "x Do Derivacija";
            this.KuteviDoDerivacijaX.Width = 120;
            // 
            // tpDuzina
            // 
            this.tpDuzina.Controls.Add(this.pnlDuzina);
            this.tpDuzina.Location = new System.Drawing.Point(4, 22);
            this.tpDuzina.Name = "tpDuzina";
            this.tpDuzina.Padding = new System.Windows.Forms.Padding(3);
            this.tpDuzina.Size = new System.Drawing.Size(693, 490);
            this.tpDuzina.TabIndex = 4;
            this.tpDuzina.Text = "Dužina";
            this.tpDuzina.UseVisualStyleBackColor = true;
            // 
            // pnlDuzina
            // 
            this.pnlDuzina.Controls.Add(this.splitContainer6);
            this.pnlDuzina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDuzina.Location = new System.Drawing.Point(3, 3);
            this.pnlDuzina.Name = "pnlDuzina";
            this.pnlDuzina.Size = new System.Drawing.Size(687, 484);
            this.pnlDuzina.TabIndex = 1;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.rtbDuzineOpis);
            this.splitContainer6.Panel1.Controls.Add(this.gb2dMjerenjeDuzine);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.gb2dDuzineMjerenja);
            this.splitContainer6.Size = new System.Drawing.Size(687, 484);
            this.splitContainer6.SplitterDistance = 241;
            this.splitContainer6.TabIndex = 0;
            // 
            // rtbDuzineOpis
            // 
            this.rtbDuzineOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDuzineOpis.Location = new System.Drawing.Point(3, 308);
            this.rtbDuzineOpis.Name = "rtbDuzineOpis";
            this.rtbDuzineOpis.Size = new System.Drawing.Size(234, 173);
            this.rtbDuzineOpis.TabIndex = 5;
            this.rtbDuzineOpis.Text = "";
            // 
            // gb2dMjerenjeDuzine
            // 
            this.gb2dMjerenjeDuzine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2dMjerenjeDuzine.Controls.Add(this.lbl2dDuzineTolerancija);
            this.gb2dMjerenjeDuzine.Controls.Add(this.tb2dDuzineTolarancija);
            this.gb2dMjerenjeDuzine.Controls.Add(this.gb2dDuzineTezine);
            this.gb2dMjerenjeDuzine.Controls.Add(this.btn2dDodajDuzinu);
            this.gb2dMjerenjeDuzine.Controls.Add(this.lbl2dDuzinem);
            this.gb2dMjerenjeDuzine.Controls.Add(this.tb2dDuzineMjerenje);
            this.gb2dMjerenjeDuzine.Controls.Add(this.cmb2dDuzineVizura);
            this.gb2dMjerenjeDuzine.Controls.Add(this.lbl2dDuzineMjerenje);
            this.gb2dMjerenjeDuzine.Controls.Add(this.cmb2DduzineStajaliste);
            this.gb2dMjerenjeDuzine.Controls.Add(this.lbl2dDuzineVizura);
            this.gb2dMjerenjeDuzine.Controls.Add(this.lbl2dDuzineStajaliste);
            this.gb2dMjerenjeDuzine.Location = new System.Drawing.Point(3, 9);
            this.gb2dMjerenjeDuzine.Name = "gb2dMjerenjeDuzine";
            this.gb2dMjerenjeDuzine.Size = new System.Drawing.Size(234, 293);
            this.gb2dMjerenjeDuzine.TabIndex = 3;
            this.gb2dMjerenjeDuzine.TabStop = false;
            this.gb2dMjerenjeDuzine.Text = "Mjerenje";
            // 
            // lbl2dDuzineTolerancija
            // 
            this.lbl2dDuzineTolerancija.AutoSize = true;
            this.lbl2dDuzineTolerancija.Location = new System.Drawing.Point(6, 224);
            this.lbl2dDuzineTolerancija.Name = "lbl2dDuzineTolerancija";
            this.lbl2dDuzineTolerancija.Size = new System.Drawing.Size(173, 13);
            this.lbl2dDuzineTolerancija.TabIndex = 12;
            this.lbl2dDuzineTolerancija.Text = "Tolerancija odstupanja dužine [mm]";
            // 
            // tb2dDuzineTolarancija
            // 
            this.tb2dDuzineTolarancija.Location = new System.Drawing.Point(202, 221);
            this.tb2dDuzineTolarancija.MaxLength = 5;
            this.tb2dDuzineTolarancija.Name = "tb2dDuzineTolarancija";
            this.tb2dDuzineTolarancija.Size = new System.Drawing.Size(23, 20);
            this.tb2dDuzineTolarancija.TabIndex = 11;
            this.tb2dDuzineTolarancija.Text = "5";
            this.tb2dDuzineTolarancija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineTolarancija_KeyPress);
            // 
            // gb2dDuzineTezine
            // 
            this.gb2dDuzineTezine.Controls.Add(this.lbl2dDuzineSigmaBrojPonavljanja);
            this.gb2dDuzineTezine.Controls.Add(this.tb2dDuzineSigmaBrojPonavljanja);
            this.gb2dDuzineTezine.Controls.Add(this.lbl2dDuzineSigmaPpm);
            this.gb2dDuzineTezine.Controls.Add(this.lbl2dDuzineSigmaMm);
            this.gb2dDuzineTezine.Controls.Add(this.tb2dDuzineTezina);
            this.gb2dDuzineTezine.Controls.Add(this.tb2dDuzineSigmaMm);
            this.gb2dDuzineTezine.Controls.Add(this.tb2dDuzineSigmaPpm);
            this.gb2dDuzineTezine.Controls.Add(this.rb2dDuzineTezina);
            this.gb2dDuzineTezine.Controls.Add(this.rb2dDuzineSigma);
            this.gb2dDuzineTezine.Location = new System.Drawing.Point(9, 100);
            this.gb2dDuzineTezine.Name = "gb2dDuzineTezine";
            this.gb2dDuzineTezine.Size = new System.Drawing.Size(216, 107);
            this.gb2dDuzineTezine.TabIndex = 10;
            this.gb2dDuzineTezine.TabStop = false;
            this.gb2dDuzineTezine.Text = "Težina";
            // 
            // lbl2dDuzineSigmaBrojPonavljanja
            // 
            this.lbl2dDuzineSigmaBrojPonavljanja.AutoSize = true;
            this.lbl2dDuzineSigmaBrojPonavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dDuzineSigmaBrojPonavljanja.Location = new System.Drawing.Point(11, 47);
            this.lbl2dDuzineSigmaBrojPonavljanja.Name = "lbl2dDuzineSigmaBrojPonavljanja";
            this.lbl2dDuzineSigmaBrojPonavljanja.Size = new System.Drawing.Size(150, 15);
            this.lbl2dDuzineSigmaBrojPonavljanja.TabIndex = 16;
            this.lbl2dDuzineSigmaBrojPonavljanja.Text = "Broj ponavljanja mjerenja:";
            // 
            // tb2dDuzineSigmaBrojPonavljanja
            // 
            this.tb2dDuzineSigmaBrojPonavljanja.Location = new System.Drawing.Point(167, 44);
            this.tb2dDuzineSigmaBrojPonavljanja.MaxLength = 6;
            this.tb2dDuzineSigmaBrojPonavljanja.Name = "tb2dDuzineSigmaBrojPonavljanja";
            this.tb2dDuzineSigmaBrojPonavljanja.Size = new System.Drawing.Size(35, 20);
            this.tb2dDuzineSigmaBrojPonavljanja.TabIndex = 15;
            this.tb2dDuzineSigmaBrojPonavljanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineSigmaBrojPonavljanja_KeyPress);
            // 
            // lbl2dDuzineSigmaPpm
            // 
            this.lbl2dDuzineSigmaPpm.AutoSize = true;
            this.lbl2dDuzineSigmaPpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dDuzineSigmaPpm.Location = new System.Drawing.Point(184, 21);
            this.lbl2dDuzineSigmaPpm.Name = "lbl2dDuzineSigmaPpm";
            this.lbl2dDuzineSigmaPpm.Size = new System.Drawing.Size(32, 15);
            this.lbl2dDuzineSigmaPpm.TabIndex = 14;
            this.lbl2dDuzineSigmaPpm.Text = "ppm";
            // 
            // lbl2dDuzineSigmaMm
            // 
            this.lbl2dDuzineSigmaMm.AutoSize = true;
            this.lbl2dDuzineSigmaMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dDuzineSigmaMm.Location = new System.Drawing.Point(106, 21);
            this.lbl2dDuzineSigmaMm.Name = "lbl2dDuzineSigmaMm";
            this.lbl2dDuzineSigmaMm.Size = new System.Drawing.Size(29, 15);
            this.lbl2dDuzineSigmaMm.TabIndex = 13;
            this.lbl2dDuzineSigmaMm.Text = "mm";
            // 
            // tb2dDuzineTezina
            // 
            this.tb2dDuzineTezina.Enabled = false;
            this.tb2dDuzineTezina.Location = new System.Drawing.Point(70, 70);
            this.tb2dDuzineTezina.MaxLength = 20;
            this.tb2dDuzineTezina.Name = "tb2dDuzineTezina";
            this.tb2dDuzineTezina.Size = new System.Drawing.Size(108, 20);
            this.tb2dDuzineTezina.TabIndex = 13;
            this.tb2dDuzineTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineTezina_KeyPress);
            // 
            // tb2dDuzineSigmaMm
            // 
            this.tb2dDuzineSigmaMm.Location = new System.Drawing.Point(70, 18);
            this.tb2dDuzineSigmaMm.MaxLength = 6;
            this.tb2dDuzineSigmaMm.Name = "tb2dDuzineSigmaMm";
            this.tb2dDuzineSigmaMm.Size = new System.Drawing.Size(30, 20);
            this.tb2dDuzineSigmaMm.TabIndex = 12;
            this.tb2dDuzineSigmaMm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineSigmaMm_KeyPress);
            // 
            // tb2dDuzineSigmaPpm
            // 
            this.tb2dDuzineSigmaPpm.Location = new System.Drawing.Point(139, 18);
            this.tb2dDuzineSigmaPpm.MaxLength = 6;
            this.tb2dDuzineSigmaPpm.Name = "tb2dDuzineSigmaPpm";
            this.tb2dDuzineSigmaPpm.Size = new System.Drawing.Size(39, 20);
            this.tb2dDuzineSigmaPpm.TabIndex = 11;
            this.tb2dDuzineSigmaPpm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineSigmaPpm_KeyPress);
            // 
            // rb2dDuzineTezina
            // 
            this.rb2dDuzineTezina.AutoSize = true;
            this.rb2dDuzineTezina.Location = new System.Drawing.Point(13, 71);
            this.rb2dDuzineTezina.Name = "rb2dDuzineTezina";
            this.rb2dDuzineTezina.Size = new System.Drawing.Size(60, 17);
            this.rb2dDuzineTezina.TabIndex = 1;
            this.rb2dDuzineTezina.Text = "Težina:";
            this.rb2dDuzineTezina.UseVisualStyleBackColor = true;
            // 
            // rb2dDuzineSigma
            // 
            this.rb2dDuzineSigma.AutoSize = true;
            this.rb2dDuzineSigma.Checked = true;
            this.rb2dDuzineSigma.Location = new System.Drawing.Point(13, 19);
            this.rb2dDuzineSigma.Name = "rb2dDuzineSigma";
            this.rb2dDuzineSigma.Size = new System.Drawing.Size(57, 17);
            this.rb2dDuzineSigma.TabIndex = 0;
            this.rb2dDuzineSigma.TabStop = true;
            this.rb2dDuzineSigma.Text = "Sigma:";
            this.rb2dDuzineSigma.UseVisualStyleBackColor = true;
            this.rb2dDuzineSigma.CheckedChanged += new System.EventHandler(this.rb2dDuzineSigma_CheckedChanged);
            // 
            // btn2dDodajDuzinu
            // 
            this.btn2dDodajDuzinu.Location = new System.Drawing.Point(150, 254);
            this.btn2dDodajDuzinu.Name = "btn2dDodajDuzinu";
            this.btn2dDodajDuzinu.Size = new System.Drawing.Size(75, 23);
            this.btn2dDodajDuzinu.TabIndex = 9;
            this.btn2dDodajDuzinu.Text = "Dodaj";
            this.btn2dDodajDuzinu.UseVisualStyleBackColor = true;
            this.btn2dDodajDuzinu.Click += new System.EventHandler(this.btn2dDodajDuzinu_Click);
            // 
            // lbl2dDuzinem
            // 
            this.lbl2dDuzinem.AutoSize = true;
            this.lbl2dDuzinem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dDuzinem.Location = new System.Drawing.Point(207, 75);
            this.lbl2dDuzinem.Name = "lbl2dDuzinem";
            this.lbl2dDuzinem.Size = new System.Drawing.Size(18, 15);
            this.lbl2dDuzinem.TabIndex = 6;
            this.lbl2dDuzinem.Text = "m";
            // 
            // tb2dDuzineMjerenje
            // 
            this.tb2dDuzineMjerenje.Location = new System.Drawing.Point(63, 74);
            this.tb2dDuzineMjerenje.MaxLength = 100;
            this.tb2dDuzineMjerenje.Name = "tb2dDuzineMjerenje";
            this.tb2dDuzineMjerenje.Size = new System.Drawing.Size(138, 20);
            this.tb2dDuzineMjerenje.TabIndex = 3;
            this.tb2dDuzineMjerenje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dDuzineMjerenje_KeyPress);
            // 
            // cmb2dDuzineVizura
            // 
            this.cmb2dDuzineVizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2dDuzineVizura.FormattingEnabled = true;
            this.cmb2dDuzineVizura.Location = new System.Drawing.Point(63, 47);
            this.cmb2dDuzineVizura.Name = "cmb2dDuzineVizura";
            this.cmb2dDuzineVizura.Size = new System.Drawing.Size(162, 21);
            this.cmb2dDuzineVizura.TabIndex = 1;
            // 
            // lbl2dDuzineMjerenje
            // 
            this.lbl2dDuzineMjerenje.AutoSize = true;
            this.lbl2dDuzineMjerenje.Location = new System.Drawing.Point(6, 77);
            this.lbl2dDuzineMjerenje.Name = "lbl2dDuzineMjerenje";
            this.lbl2dDuzineMjerenje.Size = new System.Drawing.Size(50, 13);
            this.lbl2dDuzineMjerenje.TabIndex = 2;
            this.lbl2dDuzineMjerenje.Text = "Mjerenje:";
            // 
            // cmb2DduzineStajaliste
            // 
            this.cmb2DduzineStajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DduzineStajaliste.FormattingEnabled = true;
            this.cmb2DduzineStajaliste.Location = new System.Drawing.Point(63, 20);
            this.cmb2DduzineStajaliste.Name = "cmb2DduzineStajaliste";
            this.cmb2DduzineStajaliste.Size = new System.Drawing.Size(162, 21);
            this.cmb2DduzineStajaliste.TabIndex = 0;
            this.cmb2DduzineStajaliste.SelectedIndexChanged += new System.EventHandler(this.cmb2DduzineStajaliste_SelectedIndexChanged);
            // 
            // lbl2dDuzineVizura
            // 
            this.lbl2dDuzineVizura.AutoSize = true;
            this.lbl2dDuzineVizura.Location = new System.Drawing.Point(19, 50);
            this.lbl2dDuzineVizura.Name = "lbl2dDuzineVizura";
            this.lbl2dDuzineVizura.Size = new System.Drawing.Size(39, 13);
            this.lbl2dDuzineVizura.TabIndex = 1;
            this.lbl2dDuzineVizura.Text = "Vizura:";
            // 
            // lbl2dDuzineStajaliste
            // 
            this.lbl2dDuzineStajaliste.AutoSize = true;
            this.lbl2dDuzineStajaliste.Location = new System.Drawing.Point(6, 23);
            this.lbl2dDuzineStajaliste.Name = "lbl2dDuzineStajaliste";
            this.lbl2dDuzineStajaliste.Size = new System.Drawing.Size(52, 13);
            this.lbl2dDuzineStajaliste.TabIndex = 0;
            this.lbl2dDuzineStajaliste.Text = "Stajalište:";
            // 
            // gb2dDuzineMjerenja
            // 
            this.gb2dDuzineMjerenja.Controls.Add(this.lvDuzina);
            this.gb2dDuzineMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb2dDuzineMjerenja.Location = new System.Drawing.Point(0, 0);
            this.gb2dDuzineMjerenja.Name = "gb2dDuzineMjerenja";
            this.gb2dDuzineMjerenja.Size = new System.Drawing.Size(442, 484);
            this.gb2dDuzineMjerenja.TabIndex = 1;
            this.gb2dDuzineMjerenja.TabStop = false;
            this.gb2dDuzineMjerenja.Text = "Mjerenja";
            // 
            // lvDuzina
            // 
            this.lvDuzina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DuzineKontrola,
            this.DuzineStajaliste,
            this.DuzineVizura,
            this.DuzineMjerenje,
            this.DuzineKoordinate,
            this.DuzineF,
            this.DuzineTezina,
            this.DuzineSigma,
            this.DuzineStajalisteDerivacijaY,
            this.DuzineStajalisteDerivacijaX,
            this.DuzineVizuraDerivacijaY,
            this.DuzineVizuraDerivacijaX});
            this.lvDuzina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDuzina.FullRowSelect = true;
            this.lvDuzina.GridLines = true;
            this.lvDuzina.HideSelection = false;
            this.lvDuzina.Location = new System.Drawing.Point(3, 16);
            this.lvDuzina.MultiSelect = false;
            this.lvDuzina.Name = "lvDuzina";
            this.lvDuzina.Size = new System.Drawing.Size(436, 465);
            this.lvDuzina.TabIndex = 0;
            this.lvDuzina.UseCompatibleStateImageBehavior = false;
            this.lvDuzina.View = System.Windows.Forms.View.Details;
            this.lvDuzina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvDuzina_MouseDown);
            // 
            // DuzineKontrola
            // 
            this.DuzineKontrola.Text = "Kontrola";
            // 
            // DuzineStajaliste
            // 
            this.DuzineStajaliste.Text = "Stajalište [Od]";
            this.DuzineStajaliste.Width = 80;
            // 
            // DuzineVizura
            // 
            this.DuzineVizura.Text = "Vizura [Do]";
            this.DuzineVizura.Width = 65;
            // 
            // DuzineMjerenje
            // 
            this.DuzineMjerenje.Text = "Mjerenje";
            this.DuzineMjerenje.Width = 56;
            // 
            // DuzineKoordinate
            // 
            this.DuzineKoordinate.Text = "Iz koord.";
            // 
            // DuzineF
            // 
            this.DuzineF.Text = "f";
            this.DuzineF.Width = 24;
            // 
            // DuzineTezina
            // 
            this.DuzineTezina.Text = "Težina";
            this.DuzineTezina.Width = 47;
            // 
            // DuzineSigma
            // 
            this.DuzineSigma.Text = "Sigma";
            this.DuzineSigma.Width = 50;
            // 
            // DuzineStajalisteDerivacijaY
            // 
            this.DuzineStajalisteDerivacijaY.Text = "y St Derivacija";
            this.DuzineStajalisteDerivacijaY.Width = 120;
            // 
            // DuzineStajalisteDerivacijaX
            // 
            this.DuzineStajalisteDerivacijaX.Text = "x St Derivacija";
            this.DuzineStajalisteDerivacijaX.Width = 120;
            // 
            // DuzineVizuraDerivacijaY
            // 
            this.DuzineVizuraDerivacijaY.Text = "y vizura Derivacija";
            this.DuzineVizuraDerivacijaY.Width = 120;
            // 
            // DuzineVizuraDerivacijaX
            // 
            this.DuzineVizuraDerivacijaX.Text = "x vizura Derivacija";
            this.DuzineVizuraDerivacijaX.Width = 120;
            // 
            // tpBazniVektor
            // 
            this.tpBazniVektor.Controls.Add(this.pnlBazniVektor);
            this.tpBazniVektor.Location = new System.Drawing.Point(4, 22);
            this.tpBazniVektor.Name = "tpBazniVektor";
            this.tpBazniVektor.Padding = new System.Windows.Forms.Padding(3);
            this.tpBazniVektor.Size = new System.Drawing.Size(693, 490);
            this.tpBazniVektor.TabIndex = 5;
            this.tpBazniVektor.Text = "Bazni vektor";
            this.tpBazniVektor.UseVisualStyleBackColor = true;
            // 
            // pnlBazniVektor
            // 
            this.pnlBazniVektor.Controls.Add(this.splitContainer7);
            this.pnlBazniVektor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBazniVektor.Location = new System.Drawing.Point(3, 3);
            this.pnlBazniVektor.Name = "pnlBazniVektor";
            this.pnlBazniVektor.Size = new System.Drawing.Size(687, 484);
            this.pnlBazniVektor.TabIndex = 1;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.rtbBazniVektoriOpis);
            this.splitContainer7.Panel1.Controls.Add(this.gb2dMjerenjeBazni);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.lvBazniVektor);
            this.splitContainer7.Size = new System.Drawing.Size(687, 484);
            this.splitContainer7.SplitterDistance = 239;
            this.splitContainer7.TabIndex = 0;
            // 
            // rtbBazniVektoriOpis
            // 
            this.rtbBazniVektoriOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBazniVektoriOpis.Location = new System.Drawing.Point(3, 439);
            this.rtbBazniVektoriOpis.Name = "rtbBazniVektoriOpis";
            this.rtbBazniVektoriOpis.Size = new System.Drawing.Size(234, 42);
            this.rtbBazniVektoriOpis.TabIndex = 5;
            this.rtbBazniVektoriOpis.Text = "";
            // 
            // gb2dMjerenjeBazni
            // 
            this.gb2dMjerenjeBazni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniXm);
            this.gb2dMjerenjeBazni.Controls.Add(this.tb2dBazniMjerenjeX);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniMjerenjeX);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniTolerancija);
            this.gb2dMjerenjeBazni.Controls.Add(this.tb2dBazniTolarancija);
            this.gb2dMjerenjeBazni.Controls.Add(this.gb2dBazniTezine);
            this.gb2dMjerenjeBazni.Controls.Add(this.btn2dDodajBazniVektor);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniYm);
            this.gb2dMjerenjeBazni.Controls.Add(this.tb2dBazniMjerenjeY);
            this.gb2dMjerenjeBazni.Controls.Add(this.cmb2dBazniVizura);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniMjerenjeY);
            this.gb2dMjerenjeBazni.Controls.Add(this.cmb2DbazniStajaliste);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniVizura);
            this.gb2dMjerenjeBazni.Controls.Add(this.lbl2dBazniStajaliste);
            this.gb2dMjerenjeBazni.Location = new System.Drawing.Point(3, 9);
            this.gb2dMjerenjeBazni.Name = "gb2dMjerenjeBazni";
            this.gb2dMjerenjeBazni.Size = new System.Drawing.Size(234, 424);
            this.gb2dMjerenjeBazni.TabIndex = 3;
            this.gb2dMjerenjeBazni.TabStop = false;
            this.gb2dMjerenjeBazni.Text = "Mjerenje";
            // 
            // lbl2dBazniXm
            // 
            this.lbl2dBazniXm.AutoSize = true;
            this.lbl2dBazniXm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniXm.Location = new System.Drawing.Point(207, 101);
            this.lbl2dBazniXm.Name = "lbl2dBazniXm";
            this.lbl2dBazniXm.Size = new System.Drawing.Size(18, 15);
            this.lbl2dBazniXm.TabIndex = 15;
            this.lbl2dBazniXm.Text = "m";
            // 
            // tb2dBazniMjerenjeX
            // 
            this.tb2dBazniMjerenjeX.Location = new System.Drawing.Point(63, 100);
            this.tb2dBazniMjerenjeX.MaxLength = 100;
            this.tb2dBazniMjerenjeX.Name = "tb2dBazniMjerenjeX";
            this.tb2dBazniMjerenjeX.Size = new System.Drawing.Size(138, 20);
            this.tb2dBazniMjerenjeX.TabIndex = 14;
            this.tb2dBazniMjerenjeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniMjerenjeX_KeyPress);
            // 
            // lbl2dBazniMjerenjeX
            // 
            this.lbl2dBazniMjerenjeX.AutoSize = true;
            this.lbl2dBazniMjerenjeX.Location = new System.Drawing.Point(40, 102);
            this.lbl2dBazniMjerenjeX.Name = "lbl2dBazniMjerenjeX";
            this.lbl2dBazniMjerenjeX.Size = new System.Drawing.Size(17, 13);
            this.lbl2dBazniMjerenjeX.TabIndex = 13;
            this.lbl2dBazniMjerenjeX.Text = "X:";
            // 
            // lbl2dBazniTolerancija
            // 
            this.lbl2dBazniTolerancija.AutoSize = true;
            this.lbl2dBazniTolerancija.Location = new System.Drawing.Point(6, 368);
            this.lbl2dBazniTolerancija.Name = "lbl2dBazniTolerancija";
            this.lbl2dBazniTolerancija.Size = new System.Drawing.Size(178, 13);
            this.lbl2dBazniTolerancija.TabIndex = 12;
            this.lbl2dBazniTolerancija.Text = "Tolerancija odstupanja vektora [mm]";
            // 
            // tb2dBazniTolarancija
            // 
            this.tb2dBazniTolarancija.Location = new System.Drawing.Point(202, 365);
            this.tb2dBazniTolarancija.MaxLength = 5;
            this.tb2dBazniTolarancija.Name = "tb2dBazniTolarancija";
            this.tb2dBazniTolarancija.Size = new System.Drawing.Size(23, 20);
            this.tb2dBazniTolarancija.TabIndex = 11;
            this.tb2dBazniTolarancija.Text = "5";
            this.tb2dBazniTolarancija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniTolarancija_KeyPress);
            // 
            // gb2dBazniTezine
            // 
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniTezinaX);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniTezinaX);
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniTezinaYX);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniTezinaYX);
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniTezinaY);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniTezinaY);
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniSigmaX2);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniSigmaX2);
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniSigmaYX);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniSigmaYX);
            this.gb2dBazniTezine.Controls.Add(this.lbl2dBazniSigmaY2);
            this.gb2dBazniTezine.Controls.Add(this.tb2dBazniSigmaY2);
            this.gb2dBazniTezine.Controls.Add(this.rb2dBazniTezina);
            this.gb2dBazniTezine.Controls.Add(this.rb2dBazniSigma);
            this.gb2dBazniTezine.Location = new System.Drawing.Point(9, 128);
            this.gb2dBazniTezine.Name = "gb2dBazniTezine";
            this.gb2dBazniTezine.Size = new System.Drawing.Size(216, 233);
            this.gb2dBazniTezine.TabIndex = 10;
            this.gb2dBazniTezine.TabStop = false;
            this.gb2dBazniTezine.Text = "Težina";
            // 
            // lbl2dBazniTezinaX
            // 
            this.lbl2dBazniTezinaX.AutoSize = true;
            this.lbl2dBazniTezinaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniTezinaX.Location = new System.Drawing.Point(43, 202);
            this.lbl2dBazniTezinaX.Name = "lbl2dBazniTezinaX";
            this.lbl2dBazniTezinaX.Size = new System.Drawing.Size(15, 15);
            this.lbl2dBazniTezinaX.TabIndex = 23;
            this.lbl2dBazniTezinaX.Text = "X";
            // 
            // tb2dBazniTezinaX
            // 
            this.tb2dBazniTezinaX.Enabled = false;
            this.tb2dBazniTezinaX.Location = new System.Drawing.Point(70, 202);
            this.tb2dBazniTezinaX.MaxLength = 6;
            this.tb2dBazniTezinaX.Name = "tb2dBazniTezinaX";
            this.tb2dBazniTezinaX.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniTezinaX.TabIndex = 22;
            this.tb2dBazniTezinaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniTezinaX_KeyPress);
            // 
            // lbl2dBazniTezinaYX
            // 
            this.lbl2dBazniTezinaYX.AutoSize = true;
            this.lbl2dBazniTezinaYX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniTezinaYX.Location = new System.Drawing.Point(39, 179);
            this.lbl2dBazniTezinaYX.Name = "lbl2dBazniTezinaYX";
            this.lbl2dBazniTezinaYX.Size = new System.Drawing.Size(25, 15);
            this.lbl2dBazniTezinaYX.TabIndex = 21;
            this.lbl2dBazniTezinaYX.Text = "YX ";
            // 
            // tb2dBazniTezinaYX
            // 
            this.tb2dBazniTezinaYX.Enabled = false;
            this.tb2dBazniTezinaYX.Location = new System.Drawing.Point(70, 176);
            this.tb2dBazniTezinaYX.MaxLength = 6;
            this.tb2dBazniTezinaYX.Name = "tb2dBazniTezinaYX";
            this.tb2dBazniTezinaYX.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniTezinaYX.TabIndex = 20;
            this.tb2dBazniTezinaYX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniTezinaYX_KeyPress);
            // 
            // lbl2dBazniTezinaY
            // 
            this.lbl2dBazniTezinaY.AutoSize = true;
            this.lbl2dBazniTezinaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniTezinaY.Location = new System.Drawing.Point(43, 153);
            this.lbl2dBazniTezinaY.Name = "lbl2dBazniTezinaY";
            this.lbl2dBazniTezinaY.Size = new System.Drawing.Size(14, 15);
            this.lbl2dBazniTezinaY.TabIndex = 19;
            this.lbl2dBazniTezinaY.Text = "Y";
            // 
            // tb2dBazniTezinaY
            // 
            this.tb2dBazniTezinaY.Enabled = false;
            this.tb2dBazniTezinaY.Location = new System.Drawing.Point(70, 150);
            this.tb2dBazniTezinaY.MaxLength = 6;
            this.tb2dBazniTezinaY.Name = "tb2dBazniTezinaY";
            this.tb2dBazniTezinaY.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniTezinaY.TabIndex = 18;
            this.tb2dBazniTezinaY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniTezinaY_KeyPress);
            // 
            // lbl2dBazniSigmaX2
            // 
            this.lbl2dBazniSigmaX2.AutoSize = true;
            this.lbl2dBazniSigmaX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniSigmaX2.Location = new System.Drawing.Point(33, 97);
            this.lbl2dBazniSigmaX2.Name = "lbl2dBazniSigmaX2";
            this.lbl2dBazniSigmaX2.Size = new System.Drawing.Size(59, 15);
            this.lbl2dBazniSigmaX2.TabIndex = 17;
            this.lbl2dBazniSigmaX2.Text = "X [mm^2]";
            // 
            // tb2dBazniSigmaX2
            // 
            this.tb2dBazniSigmaX2.Location = new System.Drawing.Point(97, 94);
            this.tb2dBazniSigmaX2.MaxLength = 6;
            this.tb2dBazniSigmaX2.Name = "tb2dBazniSigmaX2";
            this.tb2dBazniSigmaX2.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniSigmaX2.TabIndex = 16;
            this.tb2dBazniSigmaX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniSigmaX2_KeyPress);
            // 
            // lbl2dBazniSigmaYX
            // 
            this.lbl2dBazniSigmaYX.AutoSize = true;
            this.lbl2dBazniSigmaYX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniSigmaYX.Location = new System.Drawing.Point(25, 71);
            this.lbl2dBazniSigmaYX.Name = "lbl2dBazniSigmaYX";
            this.lbl2dBazniSigmaYX.Size = new System.Drawing.Size(66, 15);
            this.lbl2dBazniSigmaYX.TabIndex = 15;
            this.lbl2dBazniSigmaYX.Text = "YX [mm^2]";
            // 
            // tb2dBazniSigmaYX
            // 
            this.tb2dBazniSigmaYX.Location = new System.Drawing.Point(97, 68);
            this.tb2dBazniSigmaYX.MaxLength = 6;
            this.tb2dBazniSigmaYX.Name = "tb2dBazniSigmaYX";
            this.tb2dBazniSigmaYX.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniSigmaYX.TabIndex = 14;
            this.tb2dBazniSigmaYX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniSigmaYX_KeyPress);
            // 
            // lbl2dBazniSigmaY2
            // 
            this.lbl2dBazniSigmaY2.AutoSize = true;
            this.lbl2dBazniSigmaY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniSigmaY2.Location = new System.Drawing.Point(33, 45);
            this.lbl2dBazniSigmaY2.Name = "lbl2dBazniSigmaY2";
            this.lbl2dBazniSigmaY2.Size = new System.Drawing.Size(58, 15);
            this.lbl2dBazniSigmaY2.TabIndex = 13;
            this.lbl2dBazniSigmaY2.Text = "Y [mm^2]";
            // 
            // tb2dBazniSigmaY2
            // 
            this.tb2dBazniSigmaY2.Location = new System.Drawing.Point(97, 42);
            this.tb2dBazniSigmaY2.MaxLength = 6;
            this.tb2dBazniSigmaY2.Name = "tb2dBazniSigmaY2";
            this.tb2dBazniSigmaY2.Size = new System.Drawing.Size(95, 20);
            this.tb2dBazniSigmaY2.TabIndex = 12;
            this.tb2dBazniSigmaY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniSigmaY2_KeyPress);
            // 
            // rb2dBazniTezina
            // 
            this.rb2dBazniTezina.AutoSize = true;
            this.rb2dBazniTezina.Location = new System.Drawing.Point(13, 127);
            this.rb2dBazniTezina.Name = "rb2dBazniTezina";
            this.rb2dBazniTezina.Size = new System.Drawing.Size(60, 17);
            this.rb2dBazniTezina.TabIndex = 1;
            this.rb2dBazniTezina.Text = "Težina:";
            this.rb2dBazniTezina.UseVisualStyleBackColor = true;
            // 
            // rb2dBazniSigma
            // 
            this.rb2dBazniSigma.AutoSize = true;
            this.rb2dBazniSigma.Checked = true;
            this.rb2dBazniSigma.Location = new System.Drawing.Point(13, 19);
            this.rb2dBazniSigma.Name = "rb2dBazniSigma";
            this.rb2dBazniSigma.Size = new System.Drawing.Size(69, 17);
            this.rb2dBazniSigma.TabIndex = 0;
            this.rb2dBazniSigma.TabStop = true;
            this.rb2dBazniSigma.Text = "Sigma^2:";
            this.rb2dBazniSigma.UseVisualStyleBackColor = true;
            this.rb2dBazniSigma.CheckedChanged += new System.EventHandler(this.rb2dBazniSigma_CheckedChanged);
            // 
            // btn2dDodajBazniVektor
            // 
            this.btn2dDodajBazniVektor.Location = new System.Drawing.Point(150, 395);
            this.btn2dDodajBazniVektor.Name = "btn2dDodajBazniVektor";
            this.btn2dDodajBazniVektor.Size = new System.Drawing.Size(75, 23);
            this.btn2dDodajBazniVektor.TabIndex = 9;
            this.btn2dDodajBazniVektor.Text = "Dodaj";
            this.btn2dDodajBazniVektor.UseVisualStyleBackColor = true;
            this.btn2dDodajBazniVektor.Click += new System.EventHandler(this.btn2dDodajBazniVektor_Click);
            // 
            // lbl2dBazniYm
            // 
            this.lbl2dBazniYm.AutoSize = true;
            this.lbl2dBazniYm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2dBazniYm.Location = new System.Drawing.Point(207, 75);
            this.lbl2dBazniYm.Name = "lbl2dBazniYm";
            this.lbl2dBazniYm.Size = new System.Drawing.Size(18, 15);
            this.lbl2dBazniYm.TabIndex = 6;
            this.lbl2dBazniYm.Text = "m";
            // 
            // tb2dBazniMjerenjeY
            // 
            this.tb2dBazniMjerenjeY.Location = new System.Drawing.Point(63, 74);
            this.tb2dBazniMjerenjeY.MaxLength = 100;
            this.tb2dBazniMjerenjeY.Name = "tb2dBazniMjerenjeY";
            this.tb2dBazniMjerenjeY.Size = new System.Drawing.Size(138, 20);
            this.tb2dBazniMjerenjeY.TabIndex = 3;
            this.tb2dBazniMjerenjeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2dBazniMjerenjeY_KeyPress);
            // 
            // cmb2dBazniVizura
            // 
            this.cmb2dBazniVizura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2dBazniVizura.FormattingEnabled = true;
            this.cmb2dBazniVizura.Location = new System.Drawing.Point(63, 47);
            this.cmb2dBazniVizura.Name = "cmb2dBazniVizura";
            this.cmb2dBazniVizura.Size = new System.Drawing.Size(162, 21);
            this.cmb2dBazniVizura.TabIndex = 1;
            // 
            // lbl2dBazniMjerenjeY
            // 
            this.lbl2dBazniMjerenjeY.AutoSize = true;
            this.lbl2dBazniMjerenjeY.Location = new System.Drawing.Point(40, 77);
            this.lbl2dBazniMjerenjeY.Name = "lbl2dBazniMjerenjeY";
            this.lbl2dBazniMjerenjeY.Size = new System.Drawing.Size(17, 13);
            this.lbl2dBazniMjerenjeY.TabIndex = 2;
            this.lbl2dBazniMjerenjeY.Text = "Y:";
            // 
            // cmb2DbazniStajaliste
            // 
            this.cmb2DbazniStajaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2DbazniStajaliste.FormattingEnabled = true;
            this.cmb2DbazniStajaliste.Location = new System.Drawing.Point(63, 20);
            this.cmb2DbazniStajaliste.Name = "cmb2DbazniStajaliste";
            this.cmb2DbazniStajaliste.Size = new System.Drawing.Size(162, 21);
            this.cmb2DbazniStajaliste.TabIndex = 0;
            this.cmb2DbazniStajaliste.SelectedIndexChanged += new System.EventHandler(this.cmb2DbazniStajaliste_SelectedIndexChanged);
            // 
            // lbl2dBazniVizura
            // 
            this.lbl2dBazniVizura.AutoSize = true;
            this.lbl2dBazniVizura.Location = new System.Drawing.Point(19, 50);
            this.lbl2dBazniVizura.Name = "lbl2dBazniVizura";
            this.lbl2dBazniVizura.Size = new System.Drawing.Size(39, 13);
            this.lbl2dBazniVizura.TabIndex = 1;
            this.lbl2dBazniVizura.Text = "Vizura:";
            // 
            // lbl2dBazniStajaliste
            // 
            this.lbl2dBazniStajaliste.AutoSize = true;
            this.lbl2dBazniStajaliste.Location = new System.Drawing.Point(6, 23);
            this.lbl2dBazniStajaliste.Name = "lbl2dBazniStajaliste";
            this.lbl2dBazniStajaliste.Size = new System.Drawing.Size(52, 13);
            this.lbl2dBazniStajaliste.TabIndex = 0;
            this.lbl2dBazniStajaliste.Text = "Stajalište:";
            // 
            // lvBazniVektor
            // 
            this.lvBazniVektor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BazniKontrola,
            this.BazniStajaliste,
            this.BazniVizura,
            this.BazniYmjereno,
            this.BazniYkoordinate,
            this.BazniYf,
            this.BazniXmjereno,
            this.BazniXkoordinate,
            this.BazniXf,
            this.BazniTezinaY,
            this.BazniTezinaYX,
            this.BazniTezinaX,
            this.BazniSigmaY2,
            this.BazniSigmaYX,
            this.BazniSigmaX2});
            this.lvBazniVektor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBazniVektor.FullRowSelect = true;
            this.lvBazniVektor.GridLines = true;
            this.lvBazniVektor.HideSelection = false;
            this.lvBazniVektor.Location = new System.Drawing.Point(0, 0);
            this.lvBazniVektor.MultiSelect = false;
            this.lvBazniVektor.Name = "lvBazniVektor";
            this.lvBazniVektor.Size = new System.Drawing.Size(444, 484);
            this.lvBazniVektor.TabIndex = 1;
            this.lvBazniVektor.UseCompatibleStateImageBehavior = false;
            this.lvBazniVektor.View = System.Windows.Forms.View.Details;
            this.lvBazniVektor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvBazniVektor_MouseDown);
            // 
            // BazniKontrola
            // 
            this.BazniKontrola.Text = "Kontrola";
            // 
            // BazniStajaliste
            // 
            this.BazniStajaliste.Text = "Stajalište [Od]";
            this.BazniStajaliste.Width = 80;
            // 
            // BazniVizura
            // 
            this.BazniVizura.Text = "Vizura [Do]";
            this.BazniVizura.Width = 80;
            // 
            // BazniYmjereno
            // 
            this.BazniYmjereno.Text = "Y mjerenje";
            this.BazniYmjereno.Width = 100;
            // 
            // BazniYkoordinate
            // 
            this.BazniYkoordinate.Text = "Y koordinate";
            this.BazniYkoordinate.Width = 41;
            // 
            // BazniYf
            // 
            this.BazniYf.Text = "f [Y]";
            this.BazniYf.Width = 47;
            // 
            // BazniXmjereno
            // 
            this.BazniXmjereno.Text = "X mjerenje";
            this.BazniXmjereno.Width = 100;
            // 
            // BazniXkoordinate
            // 
            this.BazniXkoordinate.Text = "X koordinate";
            this.BazniXkoordinate.Width = 120;
            // 
            // BazniXf
            // 
            this.BazniXf.Text = "f [X]";
            this.BazniXf.Width = 120;
            // 
            // BazniTezinaY
            // 
            this.BazniTezinaY.Text = "Y težina";
            this.BazniTezinaY.Width = 120;
            // 
            // BazniTezinaYX
            // 
            this.BazniTezinaYX.Text = "YX težina";
            this.BazniTezinaYX.Width = 120;
            // 
            // BazniTezinaX
            // 
            this.BazniTezinaX.Text = "X težina";
            this.BazniTezinaX.Width = 120;
            // 
            // BazniSigmaY2
            // 
            this.BazniSigmaY2.Text = "Y Sigma^2";
            this.BazniSigmaY2.Width = 120;
            // 
            // BazniSigmaYX
            // 
            this.BazniSigmaYX.Text = "YX Sigma^2";
            this.BazniSigmaYX.Width = 120;
            // 
            // BazniSigmaX2
            // 
            this.BazniSigmaX2.Text = "X Sigma^2";
            this.BazniSigmaX2.Width = 120;
            // 
            // tpA
            // 
            this.tpA.Controls.Add(this.lvA);
            this.tpA.Location = new System.Drawing.Point(4, 22);
            this.tpA.Name = "tpA";
            this.tpA.Padding = new System.Windows.Forms.Padding(3);
            this.tpA.Size = new System.Drawing.Size(693, 490);
            this.tpA.TabIndex = 6;
            this.tpA.Text = "A";
            this.tpA.UseVisualStyleBackColor = true;
            // 
            // lvA
            // 
            this.lvA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvA.FullRowSelect = true;
            this.lvA.GridLines = true;
            this.lvA.Location = new System.Drawing.Point(3, 3);
            this.lvA.Name = "lvA";
            this.lvA.Size = new System.Drawing.Size(687, 484);
            this.lvA.TabIndex = 0;
            this.lvA.UseCompatibleStateImageBehavior = false;
            this.lvA.View = System.Windows.Forms.View.Details;
            // 
            // tpP
            // 
            this.tpP.Controls.Add(this.lvP);
            this.tpP.Location = new System.Drawing.Point(4, 22);
            this.tpP.Name = "tpP";
            this.tpP.Padding = new System.Windows.Forms.Padding(3);
            this.tpP.Size = new System.Drawing.Size(693, 490);
            this.tpP.TabIndex = 7;
            this.tpP.Text = "P";
            this.tpP.UseVisualStyleBackColor = true;
            // 
            // lvP
            // 
            this.lvP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvP.FullRowSelect = true;
            this.lvP.GridLines = true;
            this.lvP.Location = new System.Drawing.Point(3, 3);
            this.lvP.Name = "lvP";
            this.lvP.Size = new System.Drawing.Size(687, 484);
            this.lvP.TabIndex = 1;
            this.lvP.UseCompatibleStateImageBehavior = false;
            this.lvP.View = System.Windows.Forms.View.Details;
            // 
            // tpF
            // 
            this.tpF.Controls.Add(this.lvF);
            this.tpF.Location = new System.Drawing.Point(4, 22);
            this.tpF.Name = "tpF";
            this.tpF.Padding = new System.Windows.Forms.Padding(3);
            this.tpF.Size = new System.Drawing.Size(693, 490);
            this.tpF.TabIndex = 8;
            this.tpF.Text = "f";
            this.tpF.UseVisualStyleBackColor = true;
            // 
            // lvF
            // 
            this.lvF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvF.FullRowSelect = true;
            this.lvF.GridLines = true;
            this.lvF.Location = new System.Drawing.Point(3, 3);
            this.lvF.Name = "lvF";
            this.lvF.Size = new System.Drawing.Size(687, 484);
            this.lvF.TabIndex = 1;
            this.lvF.UseCompatibleStateImageBehavior = false;
            this.lvF.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mjerenje";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "f";
            // 
            // tpG
            // 
            this.tpG.Controls.Add(this.lvG);
            this.tpG.Location = new System.Drawing.Point(4, 22);
            this.tpG.Name = "tpG";
            this.tpG.Padding = new System.Windows.Forms.Padding(3);
            this.tpG.Size = new System.Drawing.Size(693, 490);
            this.tpG.TabIndex = 9;
            this.tpG.Text = "G";
            this.tpG.UseVisualStyleBackColor = true;
            // 
            // lvG
            // 
            this.lvG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvG.FullRowSelect = true;
            this.lvG.GridLines = true;
            this.lvG.Location = new System.Drawing.Point(3, 3);
            this.lvG.Name = "lvG";
            this.lvG.Size = new System.Drawing.Size(687, 484);
            this.lvG.TabIndex = 1;
            this.lvG.UseCompatibleStateImageBehavior = false;
            this.lvG.View = System.Windows.Forms.View.Details;
            // 
            // tpIzjednacenje
            // 
            this.tpIzjednacenje.Controls.Add(this.tcIzjednacenje);
            this.tpIzjednacenje.Location = new System.Drawing.Point(4, 22);
            this.tpIzjednacenje.Name = "tpIzjednacenje";
            this.tpIzjednacenje.Padding = new System.Windows.Forms.Padding(3);
            this.tpIzjednacenje.Size = new System.Drawing.Size(693, 490);
            this.tpIzjednacenje.TabIndex = 10;
            this.tpIzjednacenje.Text = "Izjednačenje";
            this.tpIzjednacenje.UseVisualStyleBackColor = true;
            // 
            // tcIzjednacenje
            // 
            this.tcIzjednacenje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIzjednacenje.Location = new System.Drawing.Point(3, 3);
            this.tcIzjednacenje.Name = "tcIzjednacenje";
            this.tcIzjednacenje.SelectedIndex = 0;
            this.tcIzjednacenje.Size = new System.Drawing.Size(687, 484);
            this.tcIzjednacenje.TabIndex = 1;
            // 
            // OcjenaFunkcija
            // 
            this.OcjenaFunkcija.Controls.Add(this.tabControl1);
            this.OcjenaFunkcija.Location = new System.Drawing.Point(4, 22);
            this.OcjenaFunkcija.Name = "OcjenaFunkcija";
            this.OcjenaFunkcija.Padding = new System.Windows.Forms.Padding(3);
            this.OcjenaFunkcija.Size = new System.Drawing.Size(693, 490);
            this.OcjenaFunkcija.TabIndex = 11;
            this.OcjenaFunkcija.Text = "Ocijena funkcija ";
            this.OcjenaFunkcija.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 484);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvOcjenaFunkcija);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Funkcije";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvOcjenaFunkcija
            // 
            this.lvOcjenaFunkcija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.funkcija,
            this.ocjeniva,
            this.var,
            this.stDev});
            this.lvOcjenaFunkcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOcjenaFunkcija.FullRowSelect = true;
            this.lvOcjenaFunkcija.GridLines = true;
            this.lvOcjenaFunkcija.Location = new System.Drawing.Point(3, 3);
            this.lvOcjenaFunkcija.Name = "lvOcjenaFunkcija";
            this.lvOcjenaFunkcija.Size = new System.Drawing.Size(673, 452);
            this.lvOcjenaFunkcija.TabIndex = 3;
            this.lvOcjenaFunkcija.UseCompatibleStateImageBehavior = false;
            this.lvOcjenaFunkcija.View = System.Windows.Forms.View.Details;
            // 
            // funkcija
            // 
            this.funkcija.Text = "Funkcija";
            // 
            // ocjeniva
            // 
            this.ocjeniva.Text = "Ocjenjiva";
            // 
            // var
            // 
            this.var.Text = "Varijanca";
            // 
            // stDev
            // 
            this.stDev.Text = "St. dev.";
            // 
            // IzjednaceneVelicine
            // 
            this.IzjednaceneVelicine.Controls.Add(this.tcIzjednaceneVrijednosti);
            this.IzjednaceneVelicine.Location = new System.Drawing.Point(4, 22);
            this.IzjednaceneVelicine.Name = "IzjednaceneVelicine";
            this.IzjednaceneVelicine.Padding = new System.Windows.Forms.Padding(3);
            this.IzjednaceneVelicine.Size = new System.Drawing.Size(693, 490);
            this.IzjednaceneVelicine.TabIndex = 12;
            this.IzjednaceneVelicine.Text = "Izjednačene veličine";
            this.IzjednaceneVelicine.UseVisualStyleBackColor = true;
            // 
            // tcIzjednaceneVrijednosti
            // 
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpMjerenja);
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpIzjednaceneKoordinate);
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpElipse);
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpRelativneElipse);
            this.tcIzjednaceneVrijednosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIzjednaceneVrijednosti.Location = new System.Drawing.Point(3, 3);
            this.tcIzjednaceneVrijednosti.Name = "tcIzjednaceneVrijednosti";
            this.tcIzjednaceneVrijednosti.SelectedIndex = 0;
            this.tcIzjednaceneVrijednosti.Size = new System.Drawing.Size(687, 484);
            this.tcIzjednaceneVrijednosti.TabIndex = 1;
            // 
            // tpMjerenja
            // 
            this.tpMjerenja.Controls.Add(this.lvIzjednacenaMjerenja);
            this.tpMjerenja.Location = new System.Drawing.Point(4, 22);
            this.tpMjerenja.Name = "tpMjerenja";
            this.tpMjerenja.Padding = new System.Windows.Forms.Padding(3);
            this.tpMjerenja.Size = new System.Drawing.Size(679, 458);
            this.tpMjerenja.TabIndex = 0;
            this.tpMjerenja.Text = "Mjerenja";
            this.tpMjerenja.UseVisualStyleBackColor = true;
            // 
            // lvIzjednacenaMjerenja
            // 
            this.lvIzjednacenaMjerenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvIzjednacenaMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIzjednacenaMjerenja.Location = new System.Drawing.Point(3, 3);
            this.lvIzjednacenaMjerenja.Name = "lvIzjednacenaMjerenja";
            this.lvIzjednacenaMjerenja.Size = new System.Drawing.Size(673, 452);
            this.lvIzjednacenaMjerenja.TabIndex = 0;
            this.lvIzjednacenaMjerenja.UseCompatibleStateImageBehavior = false;
            this.lvIzjednacenaMjerenja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mjerenje";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Izmjereno";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Popravka";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Izjednačeno mjerenje";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "q";
            this.columnHeader7.Width = 26;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "[A priori] s0^2 q";
            this.columnHeader8.Width = 63;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "[A priori] s0 q";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "[A posteriori] s0^2 q";
            this.columnHeader10.Width = 82;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "[A posteriori] s0 q";
            this.columnHeader11.Width = 85;
            // 
            // tpIzjednaceneKoordinate
            // 
            this.tpIzjednaceneKoordinate.Controls.Add(this.lvIzjednaceneKoordinate);
            this.tpIzjednaceneKoordinate.Location = new System.Drawing.Point(4, 22);
            this.tpIzjednaceneKoordinate.Name = "tpIzjednaceneKoordinate";
            this.tpIzjednaceneKoordinate.Padding = new System.Windows.Forms.Padding(3);
            this.tpIzjednaceneKoordinate.Size = new System.Drawing.Size(679, 458);
            this.tpIzjednaceneKoordinate.TabIndex = 1;
            this.tpIzjednaceneKoordinate.Text = "Izjednačene koordinate";
            this.tpIzjednaceneKoordinate.UseVisualStyleBackColor = true;
            // 
            // lvIzjednaceneKoordinate
            // 
            this.lvIzjednaceneKoordinate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.lvIzjednaceneKoordinate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIzjednaceneKoordinate.FullRowSelect = true;
            this.lvIzjednaceneKoordinate.GridLines = true;
            this.lvIzjednaceneKoordinate.Location = new System.Drawing.Point(3, 3);
            this.lvIzjednaceneKoordinate.Name = "lvIzjednaceneKoordinate";
            this.lvIzjednaceneKoordinate.Size = new System.Drawing.Size(673, 452);
            this.lvIzjednaceneKoordinate.TabIndex = 1;
            this.lvIzjednaceneKoordinate.UseCompatibleStateImageBehavior = false;
            this.lvIzjednaceneKoordinate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mjerenje";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Izmjereno";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Popravka";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Izjednačeno mjerenje";
            this.columnHeader15.Width = 116;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "q";
            this.columnHeader16.Width = 26;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "[A priori] s0^2 q";
            this.columnHeader17.Width = 63;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "[A priori] s0 q";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "[A posteriori] s0^2 q";
            this.columnHeader19.Width = 82;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "[A posteriori] s0 q";
            this.columnHeader20.Width = 85;
            // 
            // tpElipse
            // 
            this.tpElipse.Controls.Add(this.lvElipsa);
            this.tpElipse.Location = new System.Drawing.Point(4, 22);
            this.tpElipse.Name = "tpElipse";
            this.tpElipse.Size = new System.Drawing.Size(679, 458);
            this.tpElipse.TabIndex = 2;
            this.tpElipse.Text = "Elipse";
            this.tpElipse.UseVisualStyleBackColor = true;
            // 
            // lvElipsa
            // 
            this.lvElipsa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvElipsa.FullRowSelect = true;
            this.lvElipsa.GridLines = true;
            this.lvElipsa.Location = new System.Drawing.Point(0, 0);
            this.lvElipsa.Name = "lvElipsa";
            this.lvElipsa.Size = new System.Drawing.Size(679, 458);
            this.lvElipsa.TabIndex = 2;
            this.lvElipsa.UseCompatibleStateImageBehavior = false;
            this.lvElipsa.View = System.Windows.Forms.View.Details;
            // 
            // tpRelativneElipse
            // 
            this.tpRelativneElipse.Controls.Add(this.lvElipsaRelativna);
            this.tpRelativneElipse.Location = new System.Drawing.Point(4, 22);
            this.tpRelativneElipse.Name = "tpRelativneElipse";
            this.tpRelativneElipse.Size = new System.Drawing.Size(679, 458);
            this.tpRelativneElipse.TabIndex = 3;
            this.tpRelativneElipse.Text = "Relativne elipse";
            this.tpRelativneElipse.UseVisualStyleBackColor = true;
            // 
            // lvElipsaRelativna
            // 
            this.lvElipsaRelativna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvElipsaRelativna.FullRowSelect = true;
            this.lvElipsaRelativna.GridLines = true;
            this.lvElipsaRelativna.Location = new System.Drawing.Point(0, 0);
            this.lvElipsaRelativna.Name = "lvElipsaRelativna";
            this.lvElipsaRelativna.Size = new System.Drawing.Size(679, 458);
            this.lvElipsaRelativna.TabIndex = 2;
            this.lvElipsaRelativna.UseCompatibleStateImageBehavior = false;
            this.lvElipsaRelativna.View = System.Windows.Forms.View.Details;
            // 
            // tpStatistika
            // 
            this.tpStatistika.Controls.Add(this.lvStatistika);
            this.tpStatistika.Location = new System.Drawing.Point(4, 22);
            this.tpStatistika.Name = "tpStatistika";
            this.tpStatistika.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatistika.Size = new System.Drawing.Size(693, 490);
            this.tpStatistika.TabIndex = 13;
            this.tpStatistika.Text = "Statističko testiranje";
            this.tpStatistika.UseVisualStyleBackColor = true;
            // 
            // lvStatistika
            // 
            this.lvStatistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStatistika.FullRowSelect = true;
            this.lvStatistika.GridLines = true;
            this.lvStatistika.Location = new System.Drawing.Point(3, 3);
            this.lvStatistika.Name = "lvStatistika";
            this.lvStatistika.Size = new System.Drawing.Size(687, 484);
            this.lvStatistika.TabIndex = 2;
            this.lvStatistika.UseCompatibleStateImageBehavior = false;
            this.lvStatistika.View = System.Windows.Forms.View.Details;
            // 
            // tpTestPouzdanostiFigure
            // 
            this.tpTestPouzdanostiFigure.Controls.Add(this.lvTestPouzdanosti);
            this.tpTestPouzdanostiFigure.Location = new System.Drawing.Point(4, 22);
            this.tpTestPouzdanostiFigure.Name = "tpTestPouzdanostiFigure";
            this.tpTestPouzdanostiFigure.Padding = new System.Windows.Forms.Padding(3);
            this.tpTestPouzdanostiFigure.Size = new System.Drawing.Size(693, 490);
            this.tpTestPouzdanostiFigure.TabIndex = 14;
            this.tpTestPouzdanostiFigure.Text = "Test pouzdanosti figure";
            this.tpTestPouzdanostiFigure.UseVisualStyleBackColor = true;
            // 
            // lvTestPouzdanosti
            // 
            this.lvTestPouzdanosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTestPouzdanosti.FullRowSelect = true;
            this.lvTestPouzdanosti.GridLines = true;
            this.lvTestPouzdanosti.Location = new System.Drawing.Point(3, 3);
            this.lvTestPouzdanosti.Name = "lvTestPouzdanosti";
            this.lvTestPouzdanosti.Size = new System.Drawing.Size(687, 484);
            this.lvTestPouzdanosti.TabIndex = 3;
            this.lvTestPouzdanosti.UseCompatibleStateImageBehavior = false;
            this.lvTestPouzdanosti.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izjednacenje 2D mreže";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbVrstaIzjednacenja.ResumeLayout(false);
            this.gbVrstaIzjednacenja.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpTocke.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbKlasicanNacin.ResumeLayout(false);
            this.gbKlasicanNacin.PerformLayout();
            this.gbKlasicanMjerilo.ResumeLayout(false);
            this.gbKlasicanMjerilo.PerformLayout();
            this.gbKlasicanRotacija.ResumeLayout(false);
            this.gbKlasicanRotacija.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb2Dkoordinate.ResumeLayout(false);
            this.gb2Dkoordinate.PerformLayout();
            this.tpAzimut.ResumeLayout(false);
            this.pnlAzimut.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gb2dMjerenjeAzimuti.ResumeLayout(false);
            this.gb2dMjerenjeAzimuti.PerformLayout();
            this.gb2dAzimutiTezine.ResumeLayout(false);
            this.gb2dAzimutiTezine.PerformLayout();
            this.gb2dAzimutiMjerenja.ResumeLayout(false);
            this.tpPravac.ResumeLayout(false);
            this.pnlPravac.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gb2dMjerenjePravci.ResumeLayout(false);
            this.gb2dMjerenjePravci.PerformLayout();
            this.gb2dPravciTezine.ResumeLayout(false);
            this.gb2dPravciTezine.PerformLayout();
            this.gb2dPravciMjerenja.ResumeLayout(false);
            this.tpKut.ResumeLayout(false);
            this.pnlKut.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.gb2dKuteviMjerenje.ResumeLayout(false);
            this.gb2dKuteviMjerenje.PerformLayout();
            this.gb2dKuteviTezina.ResumeLayout(false);
            this.gb2dKuteviTezina.PerformLayout();
            this.gb2dKuteviMjerenja.ResumeLayout(false);
            this.tpDuzina.ResumeLayout(false);
            this.pnlDuzina.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.gb2dMjerenjeDuzine.ResumeLayout(false);
            this.gb2dMjerenjeDuzine.PerformLayout();
            this.gb2dDuzineTezine.ResumeLayout(false);
            this.gb2dDuzineTezine.PerformLayout();
            this.gb2dDuzineMjerenja.ResumeLayout(false);
            this.tpBazniVektor.ResumeLayout(false);
            this.pnlBazniVektor.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.gb2dMjerenjeBazni.ResumeLayout(false);
            this.gb2dMjerenjeBazni.PerformLayout();
            this.gb2dBazniTezine.ResumeLayout(false);
            this.gb2dBazniTezine.PerformLayout();
            this.tpA.ResumeLayout(false);
            this.tpP.ResumeLayout(false);
            this.tpF.ResumeLayout(false);
            this.tpG.ResumeLayout(false);
            this.tpIzjednacenje.ResumeLayout(false);
            this.OcjenaFunkcija.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.IzjednaceneVelicine.ResumeLayout(false);
            this.tcIzjednaceneVrijednosti.ResumeLayout(false);
            this.tpMjerenja.ResumeLayout(false);
            this.tpIzjednaceneKoordinate.ResumeLayout(false);
            this.tpElipse.ResumeLayout(false);
            this.tpRelativneElipse.ResumeLayout(false);
            this.tpStatistika.ResumeLayout(false);
            this.tpTestPouzdanostiFigure.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnIzjednaci;
        private System.Windows.Forms.Button btnFormirajMatrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbBazniVektor;
        private System.Windows.Forms.CheckBox ckbDuzina;
        private System.Windows.Forms.CheckBox ckbKut;
        private System.Windows.Forms.CheckBox ckbPravac;
        private System.Windows.Forms.CheckBox ckbAzimut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSigmaNulaKvadrat;
        private System.Windows.Forms.TextBox tbSigmaNula;
        private System.Windows.Forms.Label lblSigmaNulaKvadrat;
        private System.Windows.Forms.Label lblSigmaNula;
        private System.Windows.Forms.GroupBox gbVrstaIzjednacenja;
        private System.Windows.Forms.RadioButton rbIzjednacenjePrisila;
        private System.Windows.Forms.RadioButton rbKlasicanNacin;
        private System.Windows.Forms.RadioButton rbParcijalniMinimalniTrag;
        private System.Windows.Forms.RadioButton rbMinimalniTrag;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpTocke;
        private System.Windows.Forms.TabPage tpAzimut;
        private System.Windows.Forms.TabPage tpPravac;
        private System.Windows.Forms.TabPage tpKut;
        private System.Windows.Forms.TabPage tpDuzina;
        private System.Windows.Forms.TabPage tpBazniVektor;
        private System.Windows.Forms.TabPage tpA;
        private System.Windows.Forms.TabPage tpP;
        private System.Windows.Forms.TabPage tpF;
        private System.Windows.Forms.TabPage tpG;
        private System.Windows.Forms.TabPage tpIzjednacenje;
        private System.Windows.Forms.TabPage OcjenaFunkcija;
        private System.Windows.Forms.Panel pnlAzimut;
        private System.Windows.Forms.Panel pnlPravac;
        private System.Windows.Forms.Panel pnlKut;
        private System.Windows.Forms.Panel pnlDuzina;
        private System.Windows.Forms.Panel pnlBazniVektor;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gb2Dkoordinate;
        private System.Windows.Forms.Button btnDodajTocku;
        private System.Windows.Forms.Label lbl2Dx;
        private System.Windows.Forms.Label lbl2Dy;
        private System.Windows.Forms.Label lbl2Dtocka;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbTocka;
        private System.Windows.Forms.ListView lvY;
        private System.Windows.Forms.ColumnHeader Y;
        private System.Windows.Forms.ListView lvTocka;
        private System.Windows.Forms.ColumnHeader tocka;
        private System.Windows.Forms.ListView lvX;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gb2dMjerenjeAzimuti;
        private System.Windows.Forms.Label lbl2dAzimutiTolerancija;
        private System.Windows.Forms.TextBox tb2dAzimutiTolarancija;
        private System.Windows.Forms.GroupBox gb2dAzimutiTezine;
        private System.Windows.Forms.RadioButton rb2dAzimutiBrojTocaka;
        private System.Windows.Forms.TextBox tb2dAzimutBrojTocaka;
        private System.Windows.Forms.Label lbl2dAzimutSigmaSekunde;
        private System.Windows.Forms.TextBox tb2dAzimutTezina;
        private System.Windows.Forms.TextBox tb2dAzimutSigma;
        private System.Windows.Forms.RadioButton rb2dAzimutiTezina;
        private System.Windows.Forms.RadioButton rb2dAzimutiSigma;
        private System.Windows.Forms.Button btn2dDodajAzimut;
        private System.Windows.Forms.Label lbl2dAzimutiSekunde;
        private System.Windows.Forms.Label lbl2dAzimutiMinute;
        private System.Windows.Forms.Label lbl2dAzimutiStupnjevi;
        private System.Windows.Forms.TextBox tb2dAzimutiSekunde;
        private System.Windows.Forms.TextBox tb2dAzimutiMinute;
        private System.Windows.Forms.TextBox tb2dAzimutiStupnjevi;
        private System.Windows.Forms.ComboBox cmb2dAzimutiVizura;
        private System.Windows.Forms.Label lbl2dAzimutiMjerenje;
        private System.Windows.Forms.ComboBox cmb2DazimutiStajaliste;
        private System.Windows.Forms.Label lbl2dAzimutiVizura;
        private System.Windows.Forms.Label lbl2dAzimutiStajaliste;
        private System.Windows.Forms.GroupBox gb2dAzimutiMjerenja;
        private System.Windows.Forms.ListView lvAzimut;
        private System.Windows.Forms.ColumnHeader AzimutKontrola;
        private System.Windows.Forms.ColumnHeader AzimutStajaliste;
        private System.Windows.Forms.ColumnHeader AzimutVizura;
        private System.Windows.Forms.ColumnHeader AzimutMjerene;
        private System.Windows.Forms.ColumnHeader AzimutKoordinate;
        private System.Windows.Forms.ColumnHeader AzimutF;
        private System.Windows.Forms.ColumnHeader AzimutiTezina;
        private System.Windows.Forms.ColumnHeader AzimutSigma;
        private System.Windows.Forms.ColumnHeader AzimutStDerivacijaY;
        private System.Windows.Forms.ColumnHeader AzimutStDerivacijaX;
        private System.Windows.Forms.ColumnHeader AzimutVzDerivacijaY;
        private System.Windows.Forms.ColumnHeader AzimutVzDerivacijaX;
        private System.Windows.Forms.RichTextBox rtbAzimuti2dOpis;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RichTextBox rtbPravci2dOpis;
        private System.Windows.Forms.GroupBox gb2dMjerenjePravci;
        private System.Windows.Forms.Label lbl2dPravciTolerancija;
        private System.Windows.Forms.TextBox tb2dPravciTolarancijaZ;
        private System.Windows.Forms.GroupBox gb2dPravciTezine;
        private System.Windows.Forms.Label lbl2dPravciSigmaBrojGirusa;
        private System.Windows.Forms.TextBox tb2dPravciSigmaBrojGirusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2dPravciTezina;
        private System.Windows.Forms.TextBox tb2dPravciSigma;
        private System.Windows.Forms.RadioButton rb2dPravciTezina;
        private System.Windows.Forms.RadioButton rb2dPravciSigma;
        private System.Windows.Forms.Button btn2dDodajPravac;
        private System.Windows.Forms.Label lbl2dPravciSekunde;
        private System.Windows.Forms.Label lbl2dPravciMinute;
        private System.Windows.Forms.Label lbl2dPravciST;
        private System.Windows.Forms.TextBox tb2dPravciSekunde;
        private System.Windows.Forms.TextBox tb2dPravciMinute;
        private System.Windows.Forms.TextBox tb2dPravciStupnjevi;
        private System.Windows.Forms.ComboBox cmb2dPravciVizura;
        private System.Windows.Forms.Label lbl2dPravciMjerenje;
        private System.Windows.Forms.ComboBox cmb2DpravciStajaliste;
        private System.Windows.Forms.Label lbl2dPravciVizura;
        private System.Windows.Forms.Label lbl2dPravciStajaliste;
        private System.Windows.Forms.GroupBox gb2dPravciMjerenja;
        private System.Windows.Forms.ListView lvPravac;
        private System.Windows.Forms.ColumnHeader PravciZkontrola;
        private System.Windows.Forms.ColumnHeader PravciStajaliste;
        private System.Windows.Forms.ColumnHeader PravciVizura;
        private System.Windows.Forms.ColumnHeader PravciMjerenje;
        private System.Windows.Forms.ColumnHeader PravciZ;
        private System.Windows.Forms.ColumnHeader PravciZsrednje;
        private System.Windows.Forms.ColumnHeader PravciF;
        private System.Windows.Forms.ColumnHeader PravciTezina;
        private System.Windows.Forms.ColumnHeader PravciSigma;
        private System.Windows.Forms.ColumnHeader PravciStajalisteDerivacijaY;
        private System.Windows.Forms.ColumnHeader PravciStajalisteDerivacijaX;
        private System.Windows.Forms.ColumnHeader PravciVizuraDerivacijaY;
        private System.Windows.Forms.ColumnHeader PravciVizuraDerivacijaX;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox gb2dKuteviMjerenje;
        private System.Windows.Forms.ComboBox cmb2DkuteviDO;
        private System.Windows.Forms.Label lbl2dKuteviDo;
        private System.Windows.Forms.Label lbl2dKuteviTolerancija;
        private System.Windows.Forms.TextBox tb2dKuteviTolerancija;
        private System.Windows.Forms.GroupBox gb2dKuteviTezina;
        private System.Windows.Forms.Label lbl2dKuteviSigmaBrojGirusa;
        private System.Windows.Forms.TextBox tbKutSigmaBrojGirusa;
        private System.Windows.Forms.Label lbl2dKuteviSigmaKutaSekunde;
        private System.Windows.Forms.TextBox tb2dKuteviSigmaKut;
        private System.Windows.Forms.RadioButton rb2dKuteviSigmaKuta;
        private System.Windows.Forms.Label lblKuteviSigmaPravacSekunde;
        private System.Windows.Forms.TextBox tb2dKuteviSigmaPravac;
        private System.Windows.Forms.RadioButton rb2dKuteviTezina;
        private System.Windows.Forms.RadioButton rb2dKuteviSigmaPravac;
        private System.Windows.Forms.Button btn2dKuteviDodaj;
        private System.Windows.Forms.Label lbl2dKuteviMjerenjeSekunde;
        private System.Windows.Forms.Label lbl2dKuteviMjerenjeMinute;
        private System.Windows.Forms.Label lbl2dKuteviMjerenjeStupnjevi;
        private System.Windows.Forms.TextBox tb2dKuteviSekunde;
        private System.Windows.Forms.TextBox tb2dKuteviMinute;
        private System.Windows.Forms.TextBox tb2dKuteviStupnjevi;
        private System.Windows.Forms.ComboBox cmb2DkuteviOD;
        private System.Windows.Forms.Label lbl2dKuteviMjerenje;
        private System.Windows.Forms.ComboBox cmb2DkuteviStajaliste;
        private System.Windows.Forms.Label lbl2dKuteviOd;
        private System.Windows.Forms.Label lbl2dKuteviStajaliste;
        private System.Windows.Forms.GroupBox gb2dKuteviMjerenja;
        private System.Windows.Forms.ListView lvKut;
        private System.Windows.Forms.ColumnHeader KuteviKontrola;
        private System.Windows.Forms.ColumnHeader KuteviStajaliste;
        private System.Windows.Forms.ColumnHeader KuteviOD;
        private System.Windows.Forms.ColumnHeader KuteviDO;
        private System.Windows.Forms.ColumnHeader KuteviMjerenje;
        private System.Windows.Forms.ColumnHeader KuteviKoordinate;
        private System.Windows.Forms.ColumnHeader KuteviF;
        private System.Windows.Forms.ColumnHeader KuteviTezina;
        private System.Windows.Forms.ColumnHeader KuteviSigmaKuta;
        private System.Windows.Forms.ColumnHeader KuteviStajalisteDerivacijaY;
        private System.Windows.Forms.ColumnHeader KuteviStajalisteDerivacijaX;
        private System.Windows.Forms.ColumnHeader KuteviOdDerivacijaY;
        private System.Windows.Forms.ColumnHeader KuteviOdDerivacijaX;
        private System.Windows.Forms.ColumnHeader KuteviDoDerivacijaY;
        private System.Windows.Forms.ColumnHeader KuteviDoDerivacijaX;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.RichTextBox rtbDuzineOpis;
        private System.Windows.Forms.GroupBox gb2dMjerenjeDuzine;
        private System.Windows.Forms.Label lbl2dDuzineTolerancija;
        private System.Windows.Forms.TextBox tb2dDuzineTolarancija;
        private System.Windows.Forms.GroupBox gb2dDuzineTezine;
        private System.Windows.Forms.Label lbl2dDuzineSigmaBrojPonavljanja;
        private System.Windows.Forms.TextBox tb2dDuzineSigmaBrojPonavljanja;
        private System.Windows.Forms.Label lbl2dDuzineSigmaPpm;
        private System.Windows.Forms.Label lbl2dDuzineSigmaMm;
        private System.Windows.Forms.TextBox tb2dDuzineTezina;
        private System.Windows.Forms.TextBox tb2dDuzineSigmaMm;
        private System.Windows.Forms.TextBox tb2dDuzineSigmaPpm;
        private System.Windows.Forms.RadioButton rb2dDuzineTezina;
        private System.Windows.Forms.RadioButton rb2dDuzineSigma;
        private System.Windows.Forms.Button btn2dDodajDuzinu;
        private System.Windows.Forms.Label lbl2dDuzinem;
        private System.Windows.Forms.TextBox tb2dDuzineMjerenje;
        private System.Windows.Forms.ComboBox cmb2dDuzineVizura;
        private System.Windows.Forms.Label lbl2dDuzineMjerenje;
        private System.Windows.Forms.ComboBox cmb2DduzineStajaliste;
        private System.Windows.Forms.Label lbl2dDuzineVizura;
        private System.Windows.Forms.Label lbl2dDuzineStajaliste;
        private System.Windows.Forms.GroupBox gb2dDuzineMjerenja;
        private System.Windows.Forms.ListView lvDuzina;
        private System.Windows.Forms.ColumnHeader DuzineKontrola;
        private System.Windows.Forms.ColumnHeader DuzineStajaliste;
        private System.Windows.Forms.ColumnHeader DuzineVizura;
        private System.Windows.Forms.ColumnHeader DuzineMjerenje;
        private System.Windows.Forms.ColumnHeader DuzineKoordinate;
        private System.Windows.Forms.ColumnHeader DuzineF;
        private System.Windows.Forms.ColumnHeader DuzineTezina;
        private System.Windows.Forms.ColumnHeader DuzineSigma;
        private System.Windows.Forms.ColumnHeader DuzineStajalisteDerivacijaY;
        private System.Windows.Forms.ColumnHeader DuzineStajalisteDerivacijaX;
        private System.Windows.Forms.ColumnHeader DuzineVizuraDerivacijaY;
        private System.Windows.Forms.ColumnHeader DuzineVizuraDerivacijaX;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.RichTextBox rtbBazniVektoriOpis;
        private System.Windows.Forms.GroupBox gb2dMjerenjeBazni;
        private System.Windows.Forms.Label lbl2dBazniXm;
        private System.Windows.Forms.TextBox tb2dBazniMjerenjeX;
        private System.Windows.Forms.Label lbl2dBazniMjerenjeX;
        private System.Windows.Forms.Label lbl2dBazniTolerancija;
        private System.Windows.Forms.TextBox tb2dBazniTolarancija;
        private System.Windows.Forms.GroupBox gb2dBazniTezine;
        private System.Windows.Forms.Label lbl2dBazniTezinaX;
        private System.Windows.Forms.TextBox tb2dBazniTezinaX;
        private System.Windows.Forms.Label lbl2dBazniTezinaYX;
        private System.Windows.Forms.TextBox tb2dBazniTezinaYX;
        private System.Windows.Forms.Label lbl2dBazniTezinaY;
        private System.Windows.Forms.TextBox tb2dBazniTezinaY;
        private System.Windows.Forms.Label lbl2dBazniSigmaX2;
        private System.Windows.Forms.TextBox tb2dBazniSigmaX2;
        private System.Windows.Forms.Label lbl2dBazniSigmaYX;
        private System.Windows.Forms.TextBox tb2dBazniSigmaYX;
        private System.Windows.Forms.Label lbl2dBazniSigmaY2;
        private System.Windows.Forms.TextBox tb2dBazniSigmaY2;
        private System.Windows.Forms.RadioButton rb2dBazniTezina;
        private System.Windows.Forms.RadioButton rb2dBazniSigma;
        private System.Windows.Forms.Button btn2dDodajBazniVektor;
        private System.Windows.Forms.Label lbl2dBazniYm;
        private System.Windows.Forms.TextBox tb2dBazniMjerenjeY;
        private System.Windows.Forms.ComboBox cmb2dBazniVizura;
        private System.Windows.Forms.Label lbl2dBazniMjerenjeY;
        private System.Windows.Forms.ComboBox cmb2DbazniStajaliste;
        private System.Windows.Forms.Label lbl2dBazniVizura;
        private System.Windows.Forms.Label lbl2dBazniStajaliste;
        private System.Windows.Forms.ListView lvBazniVektor;
        private System.Windows.Forms.ColumnHeader BazniKontrola;
        private System.Windows.Forms.ColumnHeader BazniStajaliste;
        private System.Windows.Forms.ColumnHeader BazniVizura;
        private System.Windows.Forms.ColumnHeader BazniYmjereno;
        private System.Windows.Forms.ColumnHeader BazniYkoordinate;
        private System.Windows.Forms.ColumnHeader BazniYf;
        private System.Windows.Forms.ColumnHeader BazniXmjereno;
        private System.Windows.Forms.ColumnHeader BazniXkoordinate;
        private System.Windows.Forms.ColumnHeader BazniXf;
        private System.Windows.Forms.ColumnHeader BazniTezinaY;
        private System.Windows.Forms.ColumnHeader BazniTezinaYX;
        private System.Windows.Forms.ColumnHeader BazniTezinaX;
        private System.Windows.Forms.ColumnHeader BazniSigmaY2;
        private System.Windows.Forms.ColumnHeader BazniSigmaYX;
        private System.Windows.Forms.ColumnHeader BazniSigmaX2;
        private System.Windows.Forms.TextBox tbKutTezina;
        private System.Windows.Forms.ColumnHeader PravciSmjerni;
        private System.Windows.Forms.ListView lvA;
        private System.Windows.Forms.ListView lvP;
        private System.Windows.Forms.ListView lvF;
        private System.Windows.Forms.ListView lvG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tcIzjednacenje;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbGlobalniAlfa;
        private System.Windows.Forms.Label lblGlobalniAlfa;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbLokalniBeta;
        private System.Windows.Forms.TextBox tbLokalniAlfa;
        private System.Windows.Forms.Label lblLokalniBeta;
        private System.Windows.Forms.Label lblLokalniAlfa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvOcjenaFunkcija;
        private System.Windows.Forms.TabPage IzjednaceneVelicine;
        private System.Windows.Forms.TabControl tcIzjednaceneVrijednosti;
        private System.Windows.Forms.TabPage tpMjerenja;
        private System.Windows.Forms.ListView lvIzjednacenaMjerenja;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tpIzjednaceneKoordinate;
        private System.Windows.Forms.ListView lvIzjednaceneKoordinate;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.TabPage tpStatistika;
        private System.Windows.Forms.ListView lvStatistika;
        private System.Windows.Forms.ToolStripStatusLabel tsslVrstaIzjednacenja;
        private System.Windows.Forms.ToolStripStatusLabel tsslSigmaKvadrat;
        private System.Windows.Forms.ToolStripStatusLabel tsslSigma;
        private System.Windows.Forms.ToolStripStatusLabel tsslSo2;
        private System.Windows.Forms.ToolStripStatusLabel tsslSo;
        private System.Windows.Forms.ToolStripStatusLabel tssln;
        private System.Windows.Forms.ToolStripStatusLabel tsslu;
        private System.Windows.Forms.ToolStripStatusLabel tssld;
        private System.Windows.Forms.ToolStripStatusLabel tsslf;
        private System.Windows.Forms.ToolStripStatusLabel tsslGlobalniTest;
        private System.Windows.Forms.TabPage tpElipse;
        private System.Windows.Forms.TabPage tpRelativneElipse;
        private System.Windows.Forms.ListView lvElipsa;
        private System.Windows.Forms.ListView lvElipsaRelativna;
        private System.Windows.Forms.RichTextBox rtbKutOpis;
        private System.Windows.Forms.GroupBox gbKlasicanNacin;
        private System.Windows.Forms.GroupBox gbKlasicanMjerilo;
        private System.Windows.Forms.GroupBox gbKlasicanRotacija;
        private System.Windows.Forms.ComboBox cmbKlasicanRstajaliste;
        private System.Windows.Forms.ComboBox cmbKlasicanX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbKlasicanY;
        private System.Windows.Forms.ComboBox cmbKlasicanMstajaliste;
        private System.Windows.Forms.ComboBox cmbKlasicanRvizura;
        private System.Windows.Forms.Label lblKlasicanRvizura;
        private System.Windows.Forms.Label lblKlasicanRstajaliste;
        private System.Windows.Forms.CheckBox ckbKlasicanBazniVektor;
        private System.Windows.Forms.CheckBox ckbKlasicanDuzina;
        private System.Windows.Forms.CheckBox ckbKlasicanAzimut;
        private System.Windows.Forms.Label lblKlasicanMvizura;
        private System.Windows.Forms.ComboBox cmbKlasicanMvizura;
        private System.Windows.Forms.Label lblKlasicanMstajaliste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbKlasicanKoordinata;
        private System.Windows.Forms.TabPage tpTestPouzdanostiFigure;
        private System.Windows.Forms.ListView lvTestPouzdanosti;
        private System.Windows.Forms.ColumnHeader funkcija;
        private System.Windows.Forms.ColumnHeader ocjeniva;
        private System.Windows.Forms.ColumnHeader var;
        private System.Windows.Forms.ColumnHeader stDev;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
    }
}

