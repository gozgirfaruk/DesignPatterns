using CQRSDesign.CQRS.Commands;
using CQRSDesign.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDesign.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _handler;
        private readonly CreateProductCommandHandler _handlerCreate;
        private readonly GetProductByIdQueryHandler _handlerGetById;
        private readonly DeleteProductCommandHandler _handlerDelete;
        private readonly UpdateProductCommandHandler _handlerUpdate;

        public DefaultController(GetProductQueryHandler handler, CreateProductCommandHandler handlerCreate, GetProductByIdQueryHandler handlerGetById, DeleteProductCommandHandler handlerDelete, UpdateProductCommandHandler handlerUpdate)
        {
            _handler = handler;
            _handlerCreate = handlerCreate;
            _handlerGetById = handlerGetById;
            _handlerDelete = handlerDelete;
            _handlerUpdate = handlerUpdate;
        }

        public IActionResult ProductList()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _handlerCreate.Handle(command);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var values =_handlerGetById.Handle(new CQRS.Queries.GetProductByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetProduct(UpdateProductCommand command)
        {
            _handlerUpdate.Handle(command);
            return RedirectToAction("ProductList");
        }

        public IActionResult DeleteProduct(int id)
        {
            _handlerDelete.Handle(new DeleteProductCommand(id));
            return RedirectToAction("ProductList");
        }

    }
}
