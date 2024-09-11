using LianOk.Docking.Core;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 消费者投诉图片上传
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/pttldqbm5ttetvsy
    /// </summary>
    public class ApiHlComplaintUploadImageRequest : DockingUploadImageRequest
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.upload.image";
        }
    }
}