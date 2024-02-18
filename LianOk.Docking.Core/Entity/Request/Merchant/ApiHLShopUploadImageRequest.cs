using LianOk.Docking.Core;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 图片上传
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/bk6v8o39g8pfcdlz
    /// </summary>
    public class ApiHlShopUploadImageRequest : DockingUploadImageRequest
    {
        public override string GetApiName()
        {
            return "api.hl.shop.uploadImage";
        }
    }
}
