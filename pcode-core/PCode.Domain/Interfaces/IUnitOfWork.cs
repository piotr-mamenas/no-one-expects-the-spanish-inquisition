using System;
using System.Threading.Tasks;

namespace PCode.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CompleteAsync();
    }
}