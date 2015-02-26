﻿using System;
using System.Windows;
using Whathecode.System.Windows.DependencyPropertyFactory;
using Whathecode.System.Windows.DependencyPropertyFactory.Attributes;


namespace Whathecode.AxesPanels.Controls
{
	public class TimeLineLabel : TimeLineItem
	{
		public enum LabelProperties
		{
			Interval
		}


		static readonly Type Type = typeof( TimeLineLabel );
		public static readonly DependencyPropertyFactory<LabelProperties> Factory = new DependencyPropertyFactory<LabelProperties>();
		public static readonly DependencyProperty IntervalProperty = Factory[ LabelProperties.Interval ];


		[DependencyProperty( LabelProperties.Interval )]
		public TimeSpan Interval
		{
			get { return (TimeSpan)Factory.GetValue( this, LabelProperties.Interval ); }
			set {  Factory.SetValue( this, LabelProperties.Interval, value ); }
		}


		static TimeLineLabel()
		{
			DefaultStyleKeyProperty.OverrideMetadata( Type, new FrameworkPropertyMetadata( Type ) );
		}
	}
}
