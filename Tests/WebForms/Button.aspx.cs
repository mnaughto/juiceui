﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Juice.Framework;

namespace WebForms {
	public partial class Button : System.Web.UI.Page {

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);

			_Postback.Click += delegate(object s, EventArgs ea) {
				var o = _JuiceButton.Disabled;
			};
		}

		public void BtnPreviousClick(object sender, EventArgs e) {
			var i = 0;
		}

	}
}