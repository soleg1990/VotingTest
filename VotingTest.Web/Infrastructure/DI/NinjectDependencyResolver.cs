using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using VotingTest.DAL.EntityFramework;
using VotingTest.DAL.Interfaces;
using VotingTest.DAL.Repositories;

namespace VotingTest.Web.Infrastructure.DI
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;
        private string _connectionString = 
            @"Data Source=.\SQLEXPRESS;Initial Catalog=sovikhin_VotingTest;Integrated Security=True;Pooling=False";
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }
        private void AddBindings()
        {
            //_kernel.Bind<EFdbContext>().ToConstructor(c => new EFdbContext());
            _kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>)).WithConstructorArgument(new EFdbContext());
            _kernel.Bind<IGeneralRepository>().To<GeneralRepository>().WithConstructorArgument(_connectionString);
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}