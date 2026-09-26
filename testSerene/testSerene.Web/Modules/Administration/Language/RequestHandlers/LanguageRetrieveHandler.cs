using MyRow = testSerene.Administration.LanguageRow;

namespace testSerene.Administration;

public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), ILanguageRetrieveHandler
{
}