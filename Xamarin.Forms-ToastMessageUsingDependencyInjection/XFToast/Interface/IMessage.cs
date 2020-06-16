// 22:14
using System;
namespace XFToast.Interface
{
    public interface IMessage
    {
        void LongAlert(string message);
        void ShortAlert(string message);
    }
}
