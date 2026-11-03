namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000103")]
public interface IPromise : IResolvePromise, IRejectPromise, ICancelPromise
{

}

