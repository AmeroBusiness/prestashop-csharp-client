using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecommerce.Prestashop
{
    public interface IPrestaShopWebService
    {
        Version CurrentVersion { get; }

        async Task<XElement> Add(string resource, XElement xml);
        async Task<XElement> AddWithUrl(string url, XElement xml);

        async Task<XElement> Get(string resource);
        async Task<XElement> Get(string resource, int id);
        async Task<XElement> Get(string resource, Dictionary<string, string> options);
        async Task<XElement> Get(string resource, int? id, Dictionary<string, string> options);
        async Task<XElement> GetWithUrl(string url);

        async Task<string> Head(string resource);
        async Task<string> Head(string resource, int id);
        async Task<string> Head(string resource, int? id, Dictionary<string, string> options);
        async Task<string> HeadWithUrl(string url);

        async Task<XElement> Edit(string resource, int id, XElement xml);
        async Task<XElement> EditWithUrl(string url, XElement xml);

        async Task Delete(string resource, int id);
        async Task Delete(string resource, int[] ids);
        async Task DeleteWithUrl(string url);
    }
}
