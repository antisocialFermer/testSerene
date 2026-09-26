import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { TradeOperationsRow } from "./BackOffice.TradeOperationsRow";

export namespace TradeOperationsService {
    export const baseUrl = 'BackOffice/TradeOperations';

    export declare function Create(request: SaveRequest<TradeOperationsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TradeOperationsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TradeOperationsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TradeOperationsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TradeOperationsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TradeOperationsRow>>;

    export const Methods = {
        Create: "BackOffice/TradeOperations/Create",
        Update: "BackOffice/TradeOperations/Update",
        Delete: "BackOffice/TradeOperations/Delete",
        Retrieve: "BackOffice/TradeOperations/Retrieve",
        List: "BackOffice/TradeOperations/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>TradeOperationsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}