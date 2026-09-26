using MyRow = testSerene.Modules.BackOffice.TariffsRow;
namespace testSerene.Modules.BackOffice.Tariffs.RequestHandlers;

public interface ITariffsSaveHandler : ISaveHandler<MyRow> { }

public class TariffsSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ITariffsSaveHandler
{
}
