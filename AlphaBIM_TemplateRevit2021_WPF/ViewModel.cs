#region Namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace AlphaBIM
{
    public class $safeprojectname$ViewModel : ViewModelBase
    {
        public $safeprojectname$ViewModel(UIDocument uiDoc)
        {
        	// Khởi tạo sự kiện(nếu có) | Initialize event (if have)

            // Lưu trữ data từ Revit | Store data from Revit
            UiDoc = uiDoc;
            Doc = UiDoc.Document;

            // Khởi tạo data cho WPF | Initialize data for WPF
            Initialize();

            // Get setting(if have)

        }

        private void Initialize()
        {

        }

        #region public property

        public UIDocument UiDoc;
        public Document Doc;

        #endregion public property

        #region private variable

        private double _percent;

        #endregion private variable

		// Các method khác viết ở dưới đây | Other methods written below


    }
}
