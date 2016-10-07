namespace CodedUITest
{
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// RecordedAjoutEtudiant - Use 'RecordedAjoutEtudiantParams' to pass parameters into this method.
        /// </summary>
        public void RecordedAjoutEtudiant()
        {
            #region Variable Declarations
            HtmlHyperlink uINouvelEtudiantHyperlink = this.UIMSNCanadaCommuniquezWindow.UIIndexCodedUIAppDocument.UINouvelEtudiantHyperlink;
            HtmlEdit uINomEdit = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UINomEdit;
            HtmlEdit uIPrénomEdit = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UIPrénomEdit;
            HtmlEdit uIEmailEdit = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UIEmailEdit;
            HtmlRadioButton uISexeRadioButton = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UISexeRadioButtonH;
            HtmlEdit uIDatedeNaissanceEdit = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UIDatedeNaissanceEdit;
            HtmlInputButton uIEnregistrerButton = this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UIEnregistrerButton;
            #endregion

            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;

            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;

            if(RecordedAjoutEtudiantParams.UISexeEditText == "Femme")
                uISexeRadioButton =  this.UIMSNCanadaCommuniquezWindow.UICreateCodedUIAppDocument.UISexeRadioButtonF;

            // Click 'Nouvel Etudiant' link
            Mouse.Click(uINouvelEtudiantHyperlink, new Point(41, 8));

            // Type 'Lavoisie' in 'Nom' text box
            uINomEdit.Text = this.RecordedAjoutEtudiantParams.UINomEditText;

            // Type '{Tab}' in 'Nom' text box
            Keyboard.SendKeys(uINomEdit, this.RecordedAjoutEtudiantParams.UINomEditSendKeys, ModifierKeys.None);

            // Type 'Marie' in 'Prénom' text box
            uIPrénomEdit.Text = this.RecordedAjoutEtudiantParams.UIPrénomEditText;

            // Type '{Tab}' in 'Prénom' text box
            Keyboard.SendKeys(uIPrénomEdit, this.RecordedAjoutEtudiantParams.UIPrénomEditSendKeys, ModifierKeys.None);

            // Type 'm.lavoisie' in 'Email' text box
            uIEmailEdit.Text = this.RecordedAjoutEtudiantParams.UIEmailEditText;

            // Type 'Alt, Control + 2' in 'Email' text box
            Keyboard.SendKeys(uIEmailEdit, this.RecordedAjoutEtudiantParams.UIEmailEditSendKeys, (ModifierKeys.Alt | ModifierKeys.Control));

            // Type 'm.lavoisie@yahoo.fr' in 'Email' text box
            uIEmailEdit.Text = this.RecordedAjoutEtudiantParams.UIEmailEditText1;

            // Select 'Sexe' radio button
            uISexeRadioButton.Selected = this.RecordedAjoutEtudiantParams.UISexeRadioButton1Selected;

            // Type '{Tab}' in 'Sexe' radio button
            Keyboard.SendKeys(uISexeRadioButton, this.RecordedAjoutEtudiantParams.UISexeRadioButton1SendKeys, ModifierKeys.None);

            // Type '1998-02-01' in 'Date de Naissance' text box
            uIDatedeNaissanceEdit.Text = this.RecordedAjoutEtudiantParams.UIDatedeNaissanceEditText;

            // Click 'Enregistrer' button
            Mouse.Click(uIEnregistrerButton, new Point(51, 25));
        }

        public virtual RecordedAjoutEtudiantParams RecordedAjoutEtudiantParams
        {
            get
            {
                if ((this.mRecordedAjoutEtudiantParams == null))
                {
                    this.mRecordedAjoutEtudiantParams = new RecordedAjoutEtudiantParams();
                }
                return this.mRecordedAjoutEtudiantParams;
            }
        }

        private RecordedAjoutEtudiantParams mRecordedAjoutEtudiantParams;
    }
    /// <summary>
    /// Parameters to be passed into 'RecordedAjoutEtudiant'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.25420.1")]
    public class RecordedAjoutEtudiantParams
    {

        #region Fields
        /// <summary>
        /// Type 'Lavoisie' in 'Nom' text box
        /// </summary>
        public string UINomEditText = "Lavoisie";

        /// <summary>
        /// Type '{Tab}' in 'Nom' text box
        /// </summary>
        public string UINomEditSendKeys = "{Tab}";

        /// <summary>
        /// Type 'Marie' in 'Prénom' text box
        /// </summary>
        public string UIPrénomEditText = "Marie";

        /// <summary>
        /// Type '{Tab}' in 'Prénom' text box
        /// </summary>
        public string UIPrénomEditSendKeys = "{Tab}";

        /// <summary>
        /// Type 'm.lavoisie' in 'Email' text box
        /// </summary>
        public string UIEmailEditText = "m.lavoisie";

        /// <summary>
        /// Type 'Alt, Control + 2' in 'Email' text box
        /// </summary>
        public string UIEmailEditSendKeys = "2";

        /// <summary>
        /// Type 'm.lavoisie@yahoo.fr' in 'Email' text box
        /// </summary>
        public string UIEmailEditText1 = "m.lavoisie@yahoo.fr";


        public string UISexeEditText = "Homme";

        /// <summary>
        /// Select 'Sexe' radio button
        /// </summary>
        public bool UISexeRadioButton1Selected = true;

        /// <summary>
        /// Type '{Tab}' in 'Sexe' radio button
        /// </summary>
        public string UISexeRadioButton1SendKeys = "{Tab}";

        /// <summary>
        /// Type '1998-02-01' in 'Date de Naissance' text box
        /// </summary>
        public string UIDatedeNaissanceEditText = "1998-02-01";
        #endregion
    }
}
