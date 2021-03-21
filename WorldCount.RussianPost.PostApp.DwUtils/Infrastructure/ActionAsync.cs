using System.Threading.Tasks;

namespace WorldCount.RussianPost.PostApp.DwUtils.Infrastructure
{
    internal delegate Task ActionAsync();

    internal delegate Task ActionAsync<in T>(T parameter);
}
