using System;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Cfg;

namespace Asv.Avalonia.ToolkitGallery.Services;

public abstract class ServiceWithConfigBase<TConfig>(IConfiguration cfg) : DisposableReactiveObject
    where TConfig : new()
{
    private readonly object _sync = new();

    private readonly TConfig _config = cfg.Get<TConfig>();
    private readonly IConfiguration _cfgService =
        cfg ?? throw new ArgumentNullException(nameof(cfg));

    protected TConfigValue InternalGetConfig<TConfigValue>(Func<TConfig, TConfigValue> getProperty)
    {
        lock (_sync)
        {
            return getProperty(_config);
        }
    }

    protected void InternalSaveConfig(Action<TConfig> changeCallback)
    {
        lock (_sync)
        {
            changeCallback(_config);
            _cfgService.Set(_config);
        }
    }
}
