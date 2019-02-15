﻿using System.Collections.Generic;

namespace ThorinsCompany
{
    public class Dwarf
    {
        public readonly int accountID;
        public DwarfType DwarfType;
        public IWorkingStrategy WorkingStrategy;
        public IShoppingStrategy ShoppingStrategy;
        private Dictionary<Material, int> _materials = new Dictionary<Material, int>();
        private BankAccount _bankAccount;

        public Dwarf(DwarfType dwarfType, IShoppingStrategy shoppingStrategy, IWorkingStrategy workingStrategy)
        {
            DwarfType = dwarfType;
            ShoppingStrategy = shoppingStrategy;
            WorkingStrategy = workingStrategy;
            accountID = IDCreator.GetUniqueID();
            _bankAccount = AccountCreator.CreateNewAccount(accountID);

        }


        public Dictionary<Material, int> ShowDiggedMaterials() => _materials;
        public BankAccount GetBankAccount() => _bankAccount;
    }
}