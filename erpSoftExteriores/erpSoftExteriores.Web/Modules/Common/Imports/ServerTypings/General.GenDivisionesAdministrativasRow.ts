namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasRow {
        PrimerNivel?: string;
        SegundoNivel?: string;
        TercerNivel?: string;
        CuartoNivel?: string;
        QuintoNivel?: string;
        Id?: number;
    }

    export namespace GenDivisionesAdministrativasRow {
        export const idProperty = 'Id';
        export const nameProperty = 'PrimerNivel';
        export const localTextPrefix = 'General.GenDivisionesAdministrativas';

        export namespace Fields {
            export declare const PrimerNivel: string;
            export declare const SegundoNivel: string;
            export declare const TercerNivel: string;
            export declare const CuartoNivel: string;
            export declare const QuintoNivel: string;
            export declare const Id: string;
        }

        ['PrimerNivel', 'SegundoNivel', 'TercerNivel', 'CuartoNivel', 'QuintoNivel', 'Id'].forEach(x => (<any>Fields)[x] = x);
    }
}

