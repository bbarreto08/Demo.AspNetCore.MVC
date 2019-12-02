using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.AspNetCore.Mvc.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int itensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            itensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(itensCarrinho);
        }
    }
}
