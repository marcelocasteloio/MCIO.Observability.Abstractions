using MCIO.Core.ExecutionInfo;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MCIO.Observability.Abstractions
{
    public interface ITraceManager
    {
        // Methods
        void StartActivity(string name, ActivityKind kind, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartActivity<TInput>(string name, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartActivity<TOutput>(string name, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartActivity<TInput, TOutput>(string name, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartActivityAsync(string name, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartActivityAsync<TInput>(string name, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartActivityAsync<TOutput>(string name, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartActivityAsync<TInput, TOutput>(string name, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartInternalActivity(string name, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartInternalActivity<TInput>(string name, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartInternalActivity<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartInternalActivity<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartInternalActivityAsync(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartInternalActivityAsync<TInput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartInternalActivityAsync<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartInternalActivityAsync<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartServerActivity(string name, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartServerActivity<TInput>(string name, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartServerActivity<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartServerActivity<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartServerActivityAsync(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartServerActivityAsync<TInput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartServerActivityAsync<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartServerActivityAsync<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartClientActivity(string name, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartClientActivity<TInput>(string name, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartClientActivity<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartClientActivity<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartClientActivityAsync(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartClientActivityAsync<TInput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartClientActivityAsync<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartClientActivityAsync<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartConsumerActivity(string name, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartConsumerActivity<TInput>(string name, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartConsumerActivity<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartConsumerActivity<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartConsumerActivityAsync(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartConsumerActivityAsync<TInput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartConsumerActivityAsync<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartConsumerActivityAsync<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartProducerActivity(string name, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartProducerActivity<TInput>(string name, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartProducerActivity<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartProducerActivity<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartProducerActivityAsync<TInput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartProducerActivityAsync<TOutput>(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartProducerActivityAsync<TInput, TOutput>(string name, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task StartProducerActivityAsync(string name, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
    }
}
