using MCIO.Observability.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace MCIO.Observability.Abstractions
{
    public interface IMetricsManager
    {
        void CreateCounter<T>(string name, string unit = null, string description = null) where T : struct;
        void IncrementCounter<T>(string name, T delta) where T : struct;
        void IncrementCounter<T>(string name, T delta, params KeyValuePair<string, object>[] tags) where T : struct;
        IEnumerable<Counter> GetCounterCollection();

        void CreateHistogram<T>(string name, string unit = null, string description = null) where T : struct;
        void RecordHistogram<T>(string name, T value) where T : struct;
        void RecordHistogram<T>(string name, T value, KeyValuePair<string, object>[] tags) where T : struct;
        IEnumerable<Histogram> GetHistogramCollection();

        void CreateObservableGauge<T>(string name, Func<IEnumerable<Measurement<T>>> observeValues, string unit = null, string description = null) where T : struct;
        IEnumerable<ObservableGauge> GetObservableGaugeCollection();
    }
}
