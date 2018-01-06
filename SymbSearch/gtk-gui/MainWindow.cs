
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Notebook notebook1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Entry eSearchBox;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label lCategory;

	private global::Gtk.ComboBox cbCategory;

	private global::Gtk.Label lSymbol;

	private global::Gtk.Label lSymbolCounter;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.NodeView tvResult;

	private global::Gtk.Label lTabMain;

	private global::Gtk.VBox vbox4;

	private global::Gtk.HBox hbox1;

	private global::Gtk.ComboBox cbConversionUnit;

	private global::Gtk.Entry eConversionInput;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Label lConversionSymbol;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.NodeView tvConversionResult;

	private global::Gtk.Label lTabConversion;

	private global::Gtk.VBox vbox5;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Label lCategoryEdit;

	private global::Gtk.ComboBoxEntry cbeCategorySelect;

	private global::Gtk.Button bCreateCategory;

	private global::Gtk.Button bRemoveCategory;

	private global::Gtk.HPaned hpaned2;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Label lClassesExcluded;

	private global::Gtk.HPaned hpaned1;

	private global::Gtk.Label lClassesIncluded;

	private global::Gtk.HBox hbox7;

	private global::Gtk.ScrolledWindow GtkScrolledWindow3;

	private global::Gtk.NodeView nvClassesExcluded;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Button bIncludeSymbolClass;

	private global::Gtk.Button bExcludeSymbolClass;

	private global::Gtk.VBox vbox8;

	private global::Gtk.ScrolledWindow GtkScrolledWindow2;

	private global::Gtk.NodeView nvClassesIncluded;

	private global::Gtk.Label lTabCategories;

	private global::Gtk.VBox vbox3;

	private global::Gtk.HBox hbox3;

	private global::Gtk.CheckButton cCaseSensitive;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label lPresentation;

	private global::Gtk.ComboBox cbPresentation;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label lSymbolFont;

	private global::Gtk.FontButton fbSymbolFont;

	private global::Gtk.Label lFontExample;

	private global::Gtk.Label lTabOptions;

	private global::Gtk.ScrolledWindow GtkScrolledWindow4;

	private global::Gtk.TextView textview1;

	private global::Gtk.Label lTabAbout;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("SymbSearch");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 4;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.eSearchBox = new global::Gtk.Entry();
		this.eSearchBox.TooltipMarkup = "Search Text";
		this.eSearchBox.CanFocus = true;
		this.eSearchBox.Name = "eSearchBox";
		this.eSearchBox.IsEditable = true;
		this.eSearchBox.InvisibleChar = '•';
		this.vbox2.Add(this.eSearchBox);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.eSearchBox]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		w1.Padding = ((uint)(5));
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lCategory = new global::Gtk.Label();
		this.lCategory.Name = "lCategory";
		this.lCategory.LabelProp = global::Mono.Unix.Catalog.GetString("Category:");
		this.hbox2.Add(this.lCategory);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lCategory]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		w2.Padding = ((uint)(5));
		// Container child hbox2.Gtk.Box+BoxChild
		this.cbCategory = global::Gtk.ComboBox.NewText();
		this.cbCategory.Name = "cbCategory";
		this.cbCategory.FocusOnClick = false;
		this.hbox2.Add(this.cbCategory);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.cbCategory]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lSymbol = new global::Gtk.Label();
		this.lSymbol.Name = "lSymbol";
		this.lSymbol.Xpad = 10;
		this.lSymbol.LabelProp = global::Mono.Unix.Catalog.GetString("A");
		this.hbox2.Add(this.lSymbol);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lSymbol]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lSymbolCounter = new global::Gtk.Label();
		this.lSymbolCounter.Name = "lSymbolCounter";
		this.lSymbolCounter.LabelProp = global::Mono.Unix.Catalog.GetString("Entries: -");
		this.hbox2.Add(this.lSymbolCounter);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lSymbolCounter]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		w5.Padding = ((uint)(5));
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.tvResult = new global::Gtk.NodeView();
		this.tvResult.CanFocus = true;
		this.tvResult.Name = "tvResult";
		this.tvResult.EnableSearch = false;
		this.GtkScrolledWindow.Add(this.tvResult);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w8.Position = 2;
		this.notebook1.Add(this.vbox2);
		// Notebook tab
		this.lTabMain = new global::Gtk.Label();
		this.lTabMain.Name = "lTabMain";
		this.lTabMain.LabelProp = global::Mono.Unix.Catalog.GetString("Search");
		this.notebook1.SetTabLabel(this.vbox2, this.lTabMain);
		this.lTabMain.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.cbConversionUnit = global::Gtk.ComboBox.NewText();
		this.cbConversionUnit.AppendText(global::Mono.Unix.Catalog.GetString("Decimal"));
		this.cbConversionUnit.AppendText(global::Mono.Unix.Catalog.GetString("Hexadecimal"));
		this.cbConversionUnit.AppendText(global::Mono.Unix.Catalog.GetString("HTML Code"));
		this.cbConversionUnit.AppendText(global::Mono.Unix.Catalog.GetString("Symbol"));
		this.cbConversionUnit.Name = "cbConversionUnit";
		this.hbox1.Add(this.cbConversionUnit);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.cbConversionUnit]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		w10.Padding = ((uint)(5));
		// Container child hbox1.Gtk.Box+BoxChild
		this.eConversionInput = new global::Gtk.Entry();
		this.eConversionInput.CanFocus = true;
		this.eConversionInput.Name = "eConversionInput";
		this.eConversionInput.IsEditable = true;
		this.eConversionInput.InvisibleChar = '•';
		this.hbox1.Add(this.eConversionInput);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.eConversionInput]));
		w11.Position = 1;
		this.vbox4.Add(this.hbox1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lConversionSymbol = new global::Gtk.Label();
		this.lConversionSymbol.Name = "lConversionSymbol";
		this.lConversionSymbol.LabelProp = global::Mono.Unix.Catalog.GetString("A");
		this.hbox6.Add(this.lConversionSymbol);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.lConversionSymbol]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		w13.Padding = ((uint)(5));
		this.vbox4.Add(this.hbox6);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox6]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.tvConversionResult = new global::Gtk.NodeView();
		this.tvConversionResult.CanFocus = true;
		this.tvConversionResult.Name = "tvConversionResult";
		this.GtkScrolledWindow1.Add(this.tvConversionResult);
		this.vbox4.Add(this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow1]));
		w16.Position = 2;
		this.notebook1.Add(this.vbox4);
		global::Gtk.Notebook.NotebookChild w17 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox4]));
		w17.Position = 1;
		// Notebook tab
		this.lTabConversion = new global::Gtk.Label();
		this.lTabConversion.Name = "lTabConversion";
		this.lTabConversion.LabelProp = global::Mono.Unix.Catalog.GetString("Conversion");
		this.notebook1.SetTabLabel(this.vbox4, this.lTabConversion);
		this.lTabConversion.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.lCategoryEdit = new global::Gtk.Label();
		this.lCategoryEdit.Name = "lCategoryEdit";
		this.lCategoryEdit.LabelProp = global::Mono.Unix.Catalog.GetString("Edit Category:");
		this.hbox8.Add(this.lCategoryEdit);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lCategoryEdit]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		w18.Padding = ((uint)(5));
		// Container child hbox8.Gtk.Box+BoxChild
		this.cbeCategorySelect = global::Gtk.ComboBoxEntry.NewText();
		this.cbeCategorySelect.Name = "cbeCategorySelect";
		this.hbox8.Add(this.cbeCategorySelect);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.cbeCategorySelect]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.bCreateCategory = new global::Gtk.Button();
		this.bCreateCategory.CanFocus = true;
		this.bCreateCategory.Name = "bCreateCategory";
		this.bCreateCategory.UseUnderline = true;
		this.bCreateCategory.Label = global::Mono.Unix.Catalog.GetString("Create");
		this.hbox8.Add(this.bCreateCategory);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.bCreateCategory]));
		w20.Position = 2;
		w20.Expand = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.bRemoveCategory = new global::Gtk.Button();
		this.bRemoveCategory.CanFocus = true;
		this.bRemoveCategory.Name = "bRemoveCategory";
		this.bRemoveCategory.UseUnderline = true;
		this.bRemoveCategory.Label = global::Mono.Unix.Catalog.GetString("Remove");
		this.hbox8.Add(this.bRemoveCategory);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.bRemoveCategory]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.hpaned2 = new global::Gtk.HPaned();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 10;
		this.hbox8.Add(this.hpaned2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.hpaned2]));
		w22.PackType = ((global::Gtk.PackType)(1));
		w22.Position = 4;
		this.vbox5.Add(this.hbox8);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox8]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.lClassesExcluded = new global::Gtk.Label();
		this.lClassesExcluded.Name = "lClassesExcluded";
		this.lClassesExcluded.LabelProp = global::Mono.Unix.Catalog.GetString("Available");
		this.hbox9.Add(this.lClassesExcluded);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lClassesExcluded]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		w24.Padding = ((uint)(5));
		// Container child hbox9.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 10;
		this.hbox9.Add(this.hpaned1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hpaned1]));
		w25.Position = 1;
		// Container child hbox9.Gtk.Box+BoxChild
		this.lClassesIncluded = new global::Gtk.Label();
		this.lClassesIncluded.Name = "lClassesIncluded";
		this.lClassesIncluded.LabelProp = global::Mono.Unix.Catalog.GetString("Included");
		this.hbox9.Add(this.lClassesIncluded);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lClassesIncluded]));
		w26.Position = 2;
		w26.Expand = false;
		w26.Fill = false;
		w26.Padding = ((uint)(5));
		this.vbox5.Add(this.hbox9);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox9]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
		this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
		this.nvClassesExcluded = new global::Gtk.NodeView();
		this.nvClassesExcluded.CanFocus = true;
		this.nvClassesExcluded.Name = "nvClassesExcluded";
		this.nvClassesExcluded.HeadersVisible = false;
		this.GtkScrolledWindow3.Add(this.nvClassesExcluded);
		this.hbox7.Add(this.GtkScrolledWindow3);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.GtkScrolledWindow3]));
		w29.Position = 0;
		// Container child hbox7.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.bIncludeSymbolClass = new global::Gtk.Button();
		this.bIncludeSymbolClass.CanFocus = true;
		this.bIncludeSymbolClass.Name = "bIncludeSymbolClass";
		this.bIncludeSymbolClass.UseUnderline = true;
		this.bIncludeSymbolClass.Label = global::Mono.Unix.Catalog.GetString(">>");
		this.vbox6.Add(this.bIncludeSymbolClass);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.bIncludeSymbolClass]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.bExcludeSymbolClass = new global::Gtk.Button();
		this.bExcludeSymbolClass.CanFocus = true;
		this.bExcludeSymbolClass.Name = "bExcludeSymbolClass";
		this.bExcludeSymbolClass.UseUnderline = true;
		this.bExcludeSymbolClass.Label = global::Mono.Unix.Catalog.GetString("<<");
		this.vbox6.Add(this.bExcludeSymbolClass);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.bExcludeSymbolClass]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		this.hbox7.Add(this.vbox6);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vbox6]));
		w32.Position = 1;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.nvClassesIncluded = new global::Gtk.NodeView();
		this.nvClassesIncluded.CanFocus = true;
		this.nvClassesIncluded.Name = "nvClassesIncluded";
		this.nvClassesIncluded.HeadersVisible = false;
		this.GtkScrolledWindow2.Add(this.nvClassesIncluded);
		this.vbox8.Add(this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.GtkScrolledWindow2]));
		w34.Position = 0;
		this.hbox7.Add(this.vbox8);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vbox8]));
		w35.Position = 2;
		this.vbox5.Add(this.hbox7);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
		w36.Position = 2;
		this.notebook1.Add(this.vbox5);
		global::Gtk.Notebook.NotebookChild w37 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox5]));
		w37.Position = 2;
		// Notebook tab
		this.lTabCategories = new global::Gtk.Label();
		this.lTabCategories.Name = "lTabCategories";
		this.lTabCategories.LabelProp = global::Mono.Unix.Catalog.GetString("Categories");
		this.notebook1.SetTabLabel(this.vbox5, this.lTabCategories);
		this.lTabCategories.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.cCaseSensitive = new global::Gtk.CheckButton();
		this.cCaseSensitive.CanFocus = true;
		this.cCaseSensitive.Name = "cCaseSensitive";
		this.cCaseSensitive.Label = global::Mono.Unix.Catalog.GetString("Case Sensitive");
		this.cCaseSensitive.DrawIndicator = true;
		this.cCaseSensitive.UseUnderline = true;
		this.hbox3.Add(this.cCaseSensitive);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.cCaseSensitive]));
		w38.Position = 0;
		w38.Padding = ((uint)(5));
		this.vbox3.Add(this.hbox3);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
		w39.Position = 0;
		w39.Expand = false;
		w39.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lPresentation = new global::Gtk.Label();
		this.lPresentation.Name = "lPresentation";
		this.lPresentation.LabelProp = global::Mono.Unix.Catalog.GetString("Symbol Presentation:");
		this.hbox4.Add(this.lPresentation);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lPresentation]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		w40.Padding = ((uint)(5));
		// Container child hbox4.Gtk.Box+BoxChild
		this.cbPresentation = global::Gtk.ComboBox.NewText();
		this.cbPresentation.AppendText(global::Mono.Unix.Catalog.GetString("Symbol"));
		this.cbPresentation.AppendText(global::Mono.Unix.Catalog.GetString("HTML Code"));
		this.cbPresentation.AppendText(global::Mono.Unix.Catalog.GetString("Decimal"));
		this.cbPresentation.AppendText(global::Mono.Unix.Catalog.GetString("Hexadecimal"));
		this.cbPresentation.Name = "cbPresentation";
		this.hbox4.Add(this.cbPresentation);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.cbPresentation]));
		w41.Position = 1;
		w41.Expand = false;
		w41.Fill = false;
		w41.Padding = ((uint)(5));
		this.vbox3.Add(this.hbox4);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
		w42.Position = 1;
		w42.Expand = false;
		w42.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lSymbolFont = new global::Gtk.Label();
		this.lSymbolFont.Name = "lSymbolFont";
		this.lSymbolFont.LabelProp = global::Mono.Unix.Catalog.GetString("Symbol Font:");
		this.hbox5.Add(this.lSymbolFont);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lSymbolFont]));
		w43.Position = 0;
		w43.Expand = false;
		w43.Fill = false;
		w43.Padding = ((uint)(5));
		// Container child hbox5.Gtk.Box+BoxChild
		this.fbSymbolFont = new global::Gtk.FontButton();
		this.fbSymbolFont.CanFocus = true;
		this.fbSymbolFont.Name = "fbSymbolFont";
		this.fbSymbolFont.FontName = "Arial 20";
		this.hbox5.Add(this.fbSymbolFont);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.fbSymbolFont]));
		w44.Position = 1;
		w44.Expand = false;
		w44.Fill = false;
		w44.Padding = ((uint)(5));
		// Container child hbox5.Gtk.Box+BoxChild
		this.lFontExample = new global::Gtk.Label();
		this.lFontExample.Name = "lFontExample";
		this.lFontExample.LabelProp = global::Mono.Unix.Catalog.GetString("ABC");
		this.hbox5.Add(this.lFontExample);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lFontExample]));
		w45.Position = 2;
		w45.Expand = false;
		w45.Fill = false;
		w45.Padding = ((uint)(5));
		this.vbox3.Add(this.hbox5);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox5]));
		w46.Position = 2;
		w46.Expand = false;
		w46.Fill = false;
		this.notebook1.Add(this.vbox3);
		global::Gtk.Notebook.NotebookChild w47 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox3]));
		w47.Position = 3;
		// Notebook tab
		this.lTabOptions = new global::Gtk.Label();
		this.lTabOptions.Name = "lTabOptions";
		this.lTabOptions.LabelProp = global::Mono.Unix.Catalog.GetString("Options");
		this.notebook1.SetTabLabel(this.vbox3, this.lTabOptions);
		this.lTabOptions.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
		this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.Buffer.Text = @"Copyright (c) 2018 Oliver Krebs, Manuel Krebs aka leun4m

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.CursorVisible = false;
		this.textview1.WrapMode = ((global::Gtk.WrapMode)(2));
		this.GtkScrolledWindow4.Add(this.textview1);
		this.notebook1.Add(this.GtkScrolledWindow4);
		global::Gtk.Notebook.NotebookChild w49 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.GtkScrolledWindow4]));
		w49.Position = 4;
		// Notebook tab
		this.lTabAbout = new global::Gtk.Label();
		this.lTabAbout.Name = "lTabAbout";
		this.lTabAbout.LabelProp = global::Mono.Unix.Catalog.GetString("About");
		this.notebook1.SetTabLabel(this.GtkScrolledWindow4, this.lTabAbout);
		this.lTabAbout.ShowAll();
		this.vbox1.Add(this.notebook1);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
		w50.Position = 0;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 586;
		this.DefaultHeight = 374;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.eSearchBox.Changed += new global::System.EventHandler(this.OnESearchBoxChanged);
		this.eSearchBox.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnESearchBoxKeyPressEvent);
		this.cbCategory.Changed += new global::System.EventHandler(this.OnCbCategoryChanged);
		this.tvResult.CursorChanged += new global::System.EventHandler(this.OnTvResultCursorChanged);
		this.tvResult.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTvResultRowActivated);
		this.tvResult.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnTvResultKeyPressEvent);
		this.cbConversionUnit.Changed += new global::System.EventHandler(this.OnCbConversionUnitChanged);
		this.eConversionInput.Changed += new global::System.EventHandler(this.OnEConversionInputChanged);
		this.cbeCategorySelect.Changed += new global::System.EventHandler(this.OnCbeCategorySelectChanged);
		this.bCreateCategory.Clicked += new global::System.EventHandler(this.OnBCreateCategoryClicked);
		this.bRemoveCategory.Clicked += new global::System.EventHandler(this.OnBRemoveCategoryClicked);
		this.nvClassesExcluded.CursorChanged += new global::System.EventHandler(this.OnNvClassesExcludedCursorChanged);
		this.bIncludeSymbolClass.Clicked += new global::System.EventHandler(this.OnBIncludeSymbolClassClicked);
		this.bExcludeSymbolClass.Clicked += new global::System.EventHandler(this.OnBExcludeSymbolClassClicked);
		this.nvClassesIncluded.CursorChanged += new global::System.EventHandler(this.OnNvClassesIncludedCursorChanged);
		this.cCaseSensitive.Toggled += new global::System.EventHandler(this.OnCCaseSensitiveToggled);
		this.cbPresentation.Changed += new global::System.EventHandler(this.OnCbPresentationChanged);
		this.fbSymbolFont.FontSet += new global::System.EventHandler(this.OnFbSymbolFontFontSet);
	}
}