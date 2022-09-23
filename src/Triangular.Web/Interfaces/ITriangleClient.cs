namespace Triangular.Web.Interfaces;

public interface ITriangleClient<T, M> where T : new() where M : class
{
    Task<T?> GetPost(M model, string clientName, string path);
}
