﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace FourthCoffee.Employees
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class FourthCoffeeEmployeesModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new FourthCoffeeEmployeesModelContainer object using the connection string found in the 'FourthCoffeeEmployeesModelContainer' section of the application configuration file.
        /// </summary>
        public FourthCoffeeEmployeesModelContainer() : base("name=FourthCoffeeEmployeesModelContainer", "FourthCoffeeEmployeesModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FourthCoffeeEmployeesModelContainer object.
        /// </summary>
        public FourthCoffeeEmployeesModelContainer(string connectionString) : base(connectionString, "FourthCoffeeEmployeesModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FourthCoffeeEmployeesModelContainer object.
        /// </summary>
        public FourthCoffeeEmployeesModelContainer(EntityConnection connection) : base(connection, "FourthCoffeeEmployeesModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
