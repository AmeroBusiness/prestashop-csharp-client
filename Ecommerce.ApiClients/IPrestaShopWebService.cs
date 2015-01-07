using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecommerce.Prestashop
{
    public interface IPrestaShopWebService
    {
        Version CurrentVersion { get; }

        Task<XElement> Add(string resource, XElement xml);
        Task<XElement> AddWithUrl(string url, XElement xml);

        Task<XElement> Get(string resource);
        Task<XElement> Get(string resource, int id);
        Task<XElement> Get(string resource, Dictionary<string, string> options);
        Task<XElement> Get(string resource, int? id, Dictionary<string, string> options);
        Task<XElement> GetWithUrl(string url);

        Task<string> Head(string resource);
        Task<string> Head(string resource, int id);
        Task<string> Head(string resource, int? id, Dictionary<string, string> options);
        Task<string> HeadWithUrl(string url);

        Task<XElement> Edit(string resource, int id, XElement xml);
        Task<XElement> EditWithUrl(string url, XElement xml);

        Task Delete(string resource, int id);
        Task Delete(string resource, int[] ids);
        Task DeleteWithUrl(string url);
    }
}
