using System.Threading.Tasks;

namespace WorldCount.RussianPost.PostApps.Tracking.Infrastructure
{
    internal delegate Task ActionAsync();

    internal delegate Task ActionAsync<in T>(T parameter);
}
