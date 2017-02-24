namespace erpSoftExteriores.Logs {
    export namespace LogRegistroSimpleService {
        export const baseUrl = 'Logs/LogRegistroSimple';

        export declare function Create(request: Serenity.SaveRequest<LogRegistroSimpleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<LogRegistroSimpleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LogRegistroSimpleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LogRegistroSimpleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function SList(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LogRegistroSimpleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const SList: string;
        }

        ['Create', 'Update', 'Delete', 'Retrieve', 'List', 'SList'].forEach(x => {
            (<any>LogRegistroSimpleService)[x] = function (r, s, o) { return Q.serviceRequest(baseUrl + '/' + x, r, s, o); };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

