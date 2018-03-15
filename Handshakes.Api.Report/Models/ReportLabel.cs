﻿using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace Handshakes.Api.Report.Models
{
	public class ReportLabel : ReportElement, IReportReplaceable
	{
		public string Value
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		public OpenXmlCompositeElement Replace(Paragraph paragraph)
		{
			var prg = (Paragraph)paragraph.Clone();
			prg.RemoveAllChildren<Run>();
			prg.AppendChild(new Run(new Text(Value)));
			return prg;
		}
	}
}
