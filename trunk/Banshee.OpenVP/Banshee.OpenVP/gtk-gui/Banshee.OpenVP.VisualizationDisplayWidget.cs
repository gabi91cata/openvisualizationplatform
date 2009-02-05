// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Banshee.OpenVP {
    
    
    public partial class VisualizationDisplayWidget {
        
        private Gtk.VBox vbox1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBox visualizationList;
        
        private Gtk.CheckButton HalfResolutionCheckbox;
        
        private Gtk.Alignment glAlignment;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Banshee.OpenVP.VisualizationDisplayWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "Banshee.OpenVP.VisualizationDisplayWidget";
            // Container child Banshee.OpenVP.VisualizationDisplayWidget.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("<b>OpenVP Audio Visualizer</b>");
            this.label1.UseMarkup = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.visualizationList = new Gtk.ComboBox();
            this.visualizationList.Name = "visualizationList";
            this.hbox1.Add(this.visualizationList);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.visualizationList]));
            w2.PackType = ((Gtk.PackType)(1));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.HalfResolutionCheckbox = new Gtk.CheckButton();
            this.HalfResolutionCheckbox.CanFocus = true;
            this.HalfResolutionCheckbox.Name = "HalfResolutionCheckbox";
            this.HalfResolutionCheckbox.Label = Mono.Unix.Catalog.GetString("Half resolution");
            this.HalfResolutionCheckbox.DrawIndicator = true;
            this.HalfResolutionCheckbox.UseUnderline = true;
            this.hbox1.Add(this.HalfResolutionCheckbox);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.HalfResolutionCheckbox]));
            w3.PackType = ((Gtk.PackType)(1));
            w3.Position = 2;
            w3.Expand = false;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.glAlignment = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.glAlignment.Name = "glAlignment";
            this.vbox1.Add(this.glAlignment);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.glAlignment]));
            w5.Position = 1;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.HalfResolutionCheckbox.Toggled += new System.EventHandler(this.OnHalfResolutionCheckboxToggled);
            this.visualizationList.Changed += new System.EventHandler(this.OnVisualizationListChanged);
        }
    }
}
