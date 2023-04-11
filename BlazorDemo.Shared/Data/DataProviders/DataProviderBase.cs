using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Shared.Data.DataProviders
{
    public interface IDataProvider
    {
        Task<IObservable<int>> GetLoadingStateAsync();
    }
    sealed class DataProviderLoadingState : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnCompleted();
            return null;
        }
    }
    public abstract class DataProviderBase : IDataProvider
    {
        static readonly Task<IObservable<int>> CompletedLoadingState = Task.FromResult<IObservable<int>>(new DataProviderLoadingState());
        public virtual Task<IObservable<int>> GetLoadingStateAsync() => CompletedLoadingState;
    }
}