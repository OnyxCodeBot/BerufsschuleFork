
namespace Adressbuch
{
    partial class AdressForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label hausnummerLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label plzLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label vornameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdressForm));
            this.tscAdressen = new System.Windows.Forms.ToolStripContainer();
            this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.hausnummerTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.plzTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.mainMenue = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckvorschauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seiteEinrichtenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerDatensatzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datensatzLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.neuToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.oeffnenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.speichernToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.neuerDatensatzToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.datensatzLoeschenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.druckvorschauToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.druckenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            emailLabel = new System.Windows.Forms.Label();
            hausnummerLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            plzLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            this.tscAdressen.BottomToolStripPanel.SuspendLayout();
            this.tscAdressen.ContentPanel.SuspendLayout();
            this.tscAdressen.TopToolStripPanel.SuspendLayout();
            this.tscAdressen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
            this.personBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.mainMenue.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 130);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // hausnummerLabel
            // 
            hausnummerLabel.AutoSize = true;
            hausnummerLabel.Location = new System.Drawing.Point(221, 74);
            hausnummerLabel.Name = "hausnummerLabel";
            hausnummerLabel.Size = new System.Drawing.Size(72, 13);
            hausnummerLabel.TabIndex = 2;
            hausnummerLabel.Text = "Hausnummer:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(148, 101);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 6;
            ortLabel.Text = "Ort:";
            // 
            // plzLabel
            // 
            plzLabel.AutoSize = true;
            plzLabel.Location = new System.Drawing.Point(12, 101);
            plzLabel.Name = "plzLabel";
            plzLabel.Size = new System.Drawing.Size(24, 13);
            plzLabel.TabIndex = 8;
            plzLabel.Text = "Plz:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(12, 74);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(45, 13);
            strasseLabel.TabIndex = 10;
            strasseLabel.Text = "Strasse:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(12, 159);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Telefon:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(12, 46);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 14;
            vornameLabel.Text = "Vorname:";
            // 
            // tscAdressen
            // 
            // 
            // tscAdressen.BottomToolStripPanel
            // 
            this.tscAdressen.BottomToolStripPanel.Controls.Add(this.personBindingNavigator);
            // 
            // tscAdressen.ContentPanel
            // 
            this.tscAdressen.ContentPanel.Controls.Add(emailLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.emailTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(hausnummerLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.hausnummerTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(nameLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.nameTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(ortLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.ortTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(plzLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.plzTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(strasseLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.strasseTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(telefonLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.telefonTextBox);
            this.tscAdressen.ContentPanel.Controls.Add(vornameLabel);
            this.tscAdressen.ContentPanel.Controls.Add(this.vornameTextBox);
            this.tscAdressen.ContentPanel.Size = new System.Drawing.Size(800, 376);
            this.tscAdressen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscAdressen.Location = new System.Drawing.Point(0, 0);
            this.tscAdressen.Name = "tscAdressen";
            this.tscAdressen.Size = new System.Drawing.Size(800, 450);
            this.tscAdressen.TabIndex = 0;
            this.tscAdressen.Text = "toolStripContainer1";
            // 
            // tscAdressen.TopToolStripPanel
            // 
            this.tscAdressen.TopToolStripPanel.Controls.Add(this.mainMenue);
            this.tscAdressen.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // personBindingNavigator
            // 
            this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personBindingNavigator.BindingSource = this.personBindingSource;
            this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personBindingNavigatorSaveItem});
            this.personBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personBindingNavigator.Name = "personBindingNavigator";
            this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personBindingNavigator.Size = new System.Drawing.Size(287, 25);
            this.personBindingNavigator.TabIndex = 1;
            this.personBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Adressbuch.Person);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personBindingNavigatorSaveItem
            // 
            this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personBindingNavigatorSaveItem.Enabled = false;
            this.personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personBindingNavigatorSaveItem.Image")));
            this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
            this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(90, 127);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(236, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // hausnummerTextBox
            // 
            this.hausnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Hausnummer", true));
            this.hausnummerTextBox.Location = new System.Drawing.Point(299, 71);
            this.hausnummerTextBox.Name = "hausnummerTextBox";
            this.hausnummerTextBox.Size = new System.Drawing.Size(27, 20);
            this.hausnummerTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // ortTextBox
            // 
            this.ortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Ort", true));
            this.ortTextBox.Location = new System.Drawing.Point(178, 98);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(148, 20);
            this.ortTextBox.TabIndex = 7;
            // 
            // plzTextBox
            // 
            this.plzTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Plz", true));
            this.plzTextBox.Location = new System.Drawing.Point(90, 98);
            this.plzTextBox.Name = "plzTextBox";
            this.plzTextBox.Size = new System.Drawing.Size(50, 20);
            this.plzTextBox.TabIndex = 9;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Strasse", true));
            this.strasseTextBox.Location = new System.Drawing.Point(90, 71);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(125, 20);
            this.strasseTextBox.TabIndex = 11;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(90, 156);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(236, 20);
            this.telefonTextBox.TabIndex = 13;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(90, 43);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(236, 20);
            this.vornameTextBox.TabIndex = 15;
            // 
            // mainMenue
            // 
            this.mainMenue.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenue.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.mainMenue.Location = new System.Drawing.Point(0, 0);
            this.mainMenue.Name = "mainMenue";
            this.mainMenue.Size = new System.Drawing.Size(800, 24);
            this.mainMenue.TabIndex = 0;
            this.mainMenue.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripSeparator1,
            this.druckenToolStripMenuItem,
            this.druckvorschauToolStripMenuItem,
            this.seiteEinrichtenToolStripMenuItem,
            this.toolStripSeparator2,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripMenuItem.Image")));
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.neuToolStripMenuItem.Text = "&Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.öffnenToolStripMenuItem.Text = "&Öffnen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("druckenToolStripMenuItem.Image")));
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.druckenToolStripMenuItem.Text = "&Drucken";
            // 
            // druckvorschauToolStripMenuItem
            // 
            this.druckvorschauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("druckvorschauToolStripMenuItem.Image")));
            this.druckvorschauToolStripMenuItem.Name = "druckvorschauToolStripMenuItem";
            this.druckvorschauToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.druckvorschauToolStripMenuItem.Text = "Druck&vorschau";
            // 
            // seiteEinrichtenToolStripMenuItem
            // 
            this.seiteEinrichtenToolStripMenuItem.Name = "seiteEinrichtenToolStripMenuItem";
            this.seiteEinrichtenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.seiteEinrichtenToolStripMenuItem.Text = "Seite &Einrichten";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerDatensatzToolStripMenuItem,
            this.datensatzLöschenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // neuerDatensatzToolStripMenuItem
            // 
            this.neuerDatensatzToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuerDatensatzToolStripMenuItem.Image")));
            this.neuerDatensatzToolStripMenuItem.Name = "neuerDatensatzToolStripMenuItem";
            this.neuerDatensatzToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.neuerDatensatzToolStripMenuItem.Text = "&Neuer Datensatz";
            this.neuerDatensatzToolStripMenuItem.Click += new System.EventHandler(this.neuerDatensatzToolStripMenuItem_Click);
            // 
            // datensatzLöschenToolStripMenuItem
            // 
            this.datensatzLöschenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("datensatzLöschenToolStripMenuItem.Image")));
            this.datensatzLöschenToolStripMenuItem.Name = "datensatzLöschenToolStripMenuItem";
            this.datensatzLöschenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datensatzLöschenToolStripMenuItem.Text = "&Datensatz Löschen";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripButton,
            this.oeffnenToolStripButton,
            this.speichernToolStripButton,
            this.toolStripSeparator3,
            this.neuerDatensatzToolStripButton,
            this.datensatzLoeschenToolStripButton,
            this.toolStripSeparator4,
            this.druckvorschauToolStripButton,
            this.druckenToolStripButton,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(191, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // neuToolStripButton
            // 
            this.neuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.neuToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripButton.Image")));
            this.neuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neuToolStripButton.Name = "neuToolStripButton";
            this.neuToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.neuToolStripButton.Text = "toolStripButton1";
            // 
            // oeffnenToolStripButton
            // 
            this.oeffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oeffnenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("oeffnenToolStripButton.Image")));
            this.oeffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oeffnenToolStripButton.Name = "oeffnenToolStripButton";
            this.oeffnenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.oeffnenToolStripButton.Text = "toolStripButton2";
            // 
            // speichernToolStripButton
            // 
            this.speichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speichernToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripButton.Image")));
            this.speichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speichernToolStripButton.Name = "speichernToolStripButton";
            this.speichernToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.speichernToolStripButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // neuerDatensatzToolStripButton
            // 
            this.neuerDatensatzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.neuerDatensatzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("neuerDatensatzToolStripButton.Image")));
            this.neuerDatensatzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neuerDatensatzToolStripButton.Name = "neuerDatensatzToolStripButton";
            this.neuerDatensatzToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.neuerDatensatzToolStripButton.Text = "toolStripButton1";
            // 
            // datensatzLoeschenToolStripButton
            // 
            this.datensatzLoeschenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.datensatzLoeschenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("datensatzLoeschenToolStripButton.Image")));
            this.datensatzLoeschenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.datensatzLoeschenToolStripButton.Name = "datensatzLoeschenToolStripButton";
            this.datensatzLoeschenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.datensatzLoeschenToolStripButton.Text = "toolStripButton2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // druckvorschauToolStripButton
            // 
            this.druckvorschauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.druckvorschauToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("druckvorschauToolStripButton.Image")));
            this.druckvorschauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.druckvorschauToolStripButton.Name = "druckvorschauToolStripButton";
            this.druckvorschauToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.druckvorschauToolStripButton.Text = "toolStripButton3";
            // 
            // druckenToolStripButton
            // 
            this.druckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.druckenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("druckenToolStripButton.Image")));
            this.druckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.druckenToolStripButton.Name = "druckenToolStripButton";
            this.druckenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.druckenToolStripButton.Text = "toolStripButton4";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // AdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscAdressen);
            this.MainMenuStrip = this.mainMenue;
            this.Name = "AdressForm";
            this.Text = "Adressbuch in C#";
            this.tscAdressen.BottomToolStripPanel.ResumeLayout(false);
            this.tscAdressen.BottomToolStripPanel.PerformLayout();
            this.tscAdressen.ContentPanel.ResumeLayout(false);
            this.tscAdressen.ContentPanel.PerformLayout();
            this.tscAdressen.TopToolStripPanel.ResumeLayout(false);
            this.tscAdressen.TopToolStripPanel.PerformLayout();
            this.tscAdressen.ResumeLayout(false);
            this.tscAdressen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
            this.personBindingNavigator.ResumeLayout(false);
            this.personBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.mainMenue.ResumeLayout(false);
            this.mainMenue.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscAdressen;
        private System.Windows.Forms.MenuStrip mainMenue;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckvorschauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seiteEinrichtenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerDatensatzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datensatzLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton neuToolStripButton;
        private System.Windows.Forms.ToolStripButton oeffnenToolStripButton;
        private System.Windows.Forms.ToolStripButton speichernToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton neuerDatensatzToolStripButton;
        private System.Windows.Forms.ToolStripButton datensatzLoeschenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton druckvorschauToolStripButton;
        private System.Windows.Forms.ToolStripButton druckenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingNavigator personBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox hausnummerTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox plzTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
    }
}

