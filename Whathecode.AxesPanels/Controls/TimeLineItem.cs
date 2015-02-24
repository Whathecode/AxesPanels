﻿using System;
using System.Windows;
using System.Windows.Controls;
using Whathecode.System.Windows.DependencyPropertyFactory;
using Whathecode.System.Windows.DependencyPropertyFactory.Attributes;


namespace Whathecode.AxesPanels.Controls
{
	public class TimeLineItem : Control
	{
		public enum TimeLineItemBinding
		{
			Occurance
		}


		static readonly Type Type = typeof( TimeLineItem );
		public static readonly DependencyPropertyFactory<TimeLineItemBinding> PropertyFactory = new DependencyPropertyFactory<TimeLineItemBinding>();
		public static readonly DependencyProperty OccuranceProperty = PropertyFactory[ TimeLineItemBinding.Occurance ];

		[DependencyProperty( TimeLineItemBinding.Occurance )]
		public DateTime Occurance
		{
			get { return (DateTime)PropertyFactory.GetValue( this, TimeLineItemBinding.Occurance ); }
			set { PropertyFactory.SetValue( this, TimeLineItemBinding.Occurance, value ); }
		}


		static TimeLineItem()
		{
			DefaultStyleKeyProperty.OverrideMetadata( Type, new FrameworkPropertyMetadata( Type ) );
		}
	}
}
