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
        void StartActivity(string traceName, ActivityKind kind, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartActivity<TInput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartActivity<TOutput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartActivity<TInput, TOutput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartActivityAsync(string traceName, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartActivityAsync<TInput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartActivityAsync<TOutput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartActivityAsync<TInput, TOutput>(string traceName, ActivityKind kind, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);


        void StartInternalActivity(string traceName, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartInternalActivity<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartInternalActivity<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartInternalActivity<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartInternalActivityAsync(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartInternalActivityAsync<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartInternalActivityAsync<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartInternalActivityAsync<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartServerActivity(string traceName, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartServerActivity<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartServerActivity<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartServerActivity<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartServerActivityAsync(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartServerActivityAsync<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartServerActivityAsync<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartServerActivityAsync<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartClientActivity(string traceName, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartClientActivity<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartClientActivity<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartClientActivity<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartClientActivityAsync(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartClientActivityAsync<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartClientActivityAsync<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartClientActivityAsync<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartConsumerActivity(string traceName, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartConsumerActivity<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartConsumerActivity<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartConsumerActivity<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartConsumerActivityAsync(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task StartConsumerActivityAsync<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartConsumerActivityAsync<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartConsumerActivityAsync<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);

        void StartProducerActivity(string traceName, ExecutionInfo executionInfo, Action<Activity, ExecutionInfo> handler);
        void StartProducerActivity<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Action<Activity, ExecutionInfo, TInput> handler);
        TOutput StartProducerActivity<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, TOutput> handler);
        TOutput StartProducerActivity<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, TOutput> handler);

        Task StartProducerActivityAsync<TInput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task> handler, CancellationToken cancellationToken);
        Task<TOutput> StartProducerActivityAsync<TOutput>(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task<TOutput> StartProducerActivityAsync<TInput, TOutput>(string traceName, ExecutionInfo executionInfo, TInput input, Func<Activity, ExecutionInfo, TInput, CancellationToken, Task<TOutput>> handler, CancellationToken cancellationToken);
        Task StartProducerActivityAsync(string traceName, ExecutionInfo executionInfo, Func<Activity, ExecutionInfo, CancellationToken, Task> handler, CancellationToken cancellationToken);
    }

}
