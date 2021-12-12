using Catalog.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.UnitTests.Fixture
{
    public class ControllerFixture : IDisposable
    {
        public CatalogController catalogController { get; private set; }

        public ControllerFixture()
        {

        }

        #region ImplementIDisposableCorrectly
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ControllerFixture()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                catalogController = null;
            }
        }
        #endregion
    }
}
