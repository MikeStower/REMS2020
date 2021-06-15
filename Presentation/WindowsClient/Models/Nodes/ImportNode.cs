﻿using System;
using System.Windows.Forms;

namespace WindowsClient.Models
{
    public abstract class ImportNode<TValidator> : TreeNode, IDisposable
        where TValidator : INodeValidator
    {
        /// <summary>
        /// Occurs when some change is applied to the node
        /// </summary>
        public event EventHandler Updated;

        protected void InvokeUpdated() => Updated?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// The contents of the popup context menu when the node is right-clicked
        /// </summary>
        public ToolStripItemCollection Items => ContextMenuStrip.Items;

        /// <summary>
        /// Used to validate the data prior to import
        /// </summary>
        public virtual TValidator Validator { get; set; }

        /// <summary>
        /// The advice which is displayed alongside the node
        /// </summary>
        public Advice Advice 
        {
            get => Validator.Advice;
            set => Validator.Advice = value;
        }

        public abstract string Key { get; }

        public ImportNode(string name) : base(name)
        {
            ContextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Opening += OnMenuOpening;            
        }

        /// <summary>
        /// Handles any dynamic changes to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected abstract void OnMenuOpening(object sender, EventArgs args);        

        /// <summary>
        /// Test a node for validity
        /// </summary>
        public abstract void Validate();

        #region Disposable
        protected bool disposedValue;

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {                  
                    }
                    Updated = null;
                    disposedValue = true;
                }
            }

            public void Dispose()
            {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }
            #endregion
    }
}