﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMHierarchiesDemo.Model;

namespace MVVMHierarchiesDemo.ViewModel
{
	class AddEditCustomerViewModel : BindableBase
	{
		public AddEditCustomerViewModel()
		{
			CancelCommand = new MyICommand(OnCancel);
			SaveCommand = new MyICommand(OnSave, CanSave);
		}

		private bool _EditMode;

		public bool EditMode
		{
			get { return _EditMode; }
			set { SetProperty(ref _EditMode, value); }
		}

		private SimpleEditableCustomer _Customer;

		public SimpleEditableCustomer Customer
		{
			get { return _Customer; }
			set { SetProperty(ref _Customer, value); }
		}

		private Customer _editingCustomer = null;

		public void SetCustomer(Customer cust)
		{
			_editingCustomer = cust;

			if (Customer != null) Customer.ErrorsChanged -= RaiseCanExecuteChanged;
			Customer = new SimpleEditableCustomer();
			Customer.ErrorsChanged += RaiseCanExecuteChanged;
			CopyCustomer(cust, Customer);
		}

		private void RaiseCanExecuteChanged(object sender, EventArgs e)
		{
			SaveCommand.RaiseCanExecuteChanged();
		}

		public MyICommand CancelCommand { get; private set; }
		public MyICommand SaveCommand { get; private set; }

		public event Action Done = delegate { };

		private void OnCancel()
		{
			Done();
		}

		private void OnSave()
		{
			Done();
		}

		private bool CanSave()
		{
			return !Customer.HasErrors;
		}
	}
}
