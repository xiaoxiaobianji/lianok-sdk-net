namespace LianOk.Docking.Core
{
    public interface IDockingClient
    {
        ResponseResultBase<R> GetResponse<T, R>(T request) where T : DockingRequestBase where R : DockingResponseBase, new();
    }
}