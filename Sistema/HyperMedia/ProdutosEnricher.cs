using Tapioca.HATEOAS;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Sistema.Data.VO;


namespace Sistema.HyperMedia
{
    public class ProdutosEnricher : ObjectContentResponseEnricher<ProdutosVO>
    {
        protected override Task EnrichModel(ProdutosVO content, IUrlHelper urlHelper)
        {
            var path = "api/Produtos/v1";
            var url = new { controller = path, id = content.Id};

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.GET,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.PUT,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.DELETE,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = "int"
            });
            return null;
        }
    }
}
