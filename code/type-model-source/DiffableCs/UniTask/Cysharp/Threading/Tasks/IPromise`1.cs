namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000102")]
public interface IPromise : IResolvePromise<T>, IRejectPromise, ICancelPromise
{

}

