namespace erpSoftExteriores.Inventario {
    export interface InvProductosLegalRow {
        Id?: number;
        DocumentoUno?: string;
        DocumentoDos?: string;
        DocumentoTres?: string;
        DocumentoCuatro?: string;
        DocumentoCinco?: string;
        Vence?: string;
        Observaciones?: string;
        DocumentosDigitalizados?: string;
        TenantId?: number;
    }

    export namespace InvProductosLegalRow {
        export const idProperty = 'Id';
        export const nameProperty = 'DocumentoUno';
        export const localTextPrefix = 'Inventario.InvProductosLegal';
        export const lookupKey = 'Inventario.InvProductosLegal';

        export function getLookup(): Q.Lookup<InvProductosLegalRow> {
            return Q.getLookup<InvProductosLegalRow>('Inventario.InvProductosLegal');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const DocumentoUno: string;
            export declare const DocumentoDos: string;
            export declare const DocumentoTres: string;
            export declare const DocumentoCuatro: string;
            export declare const DocumentoCinco: string;
            export declare const Vence: string;
            export declare const Observaciones: string;
            export declare const DocumentosDigitalizados: string;
            export declare const TenantId: string;
        }

        ['Id', 'DocumentoUno', 'DocumentoDos', 'DocumentoTres', 'DocumentoCuatro', 'DocumentoCinco', 'Vence', 'Observaciones', 'DocumentosDigitalizados', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

