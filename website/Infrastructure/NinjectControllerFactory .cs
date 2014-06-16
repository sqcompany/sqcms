using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Collections.Generic;
using Ninject;
using System.Linq;
using Moq;
using domain.Entities;
using domain.Abstract;
using domain.Concrete;

namespace website.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(m => m.Books).Returns(new List<book> { 
            new book{ID=1,Price=123},
            new book{ID=1,Price=123},
            new book{ID=1,Price=123}
            }.AsQueryable());
            ninjectKernel.Bind<IBookRepository>().ToConstant(mock.Object);
            //ninjectKernel.Bind<IBookRepository>().To<BookRepository>();
        }

    }
}
