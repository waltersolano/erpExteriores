namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasN3Row {
        Id?: number;
        Codigo?: string;
        Nombre?: string;
        DivisionSuperiorN2?: number;
        DivisionSuperiorN2Codigo?: string;
        DivisionSuperiorN2Nombre?: string;
        DivisionSuperiorN2DivisionSuperiorN1?: number;
    }

    export namespace GenDivisionesAdministrativasN3Row {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenDivisionesAdministrativasN3';
        export const lookupKey = 'General.DivisionesAdministrativasN3';

        export function getLookup(): Q.Lookup<GenDivisionesAdministrativasN3Row> {
            return Q.getLookup<GenDivisionesAdministrativasN3Row>('General.DivisionesAdministrativasN3');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Codigo: string;
            export declare const Nombre: string;
            export declare const DivisionSuperiorN2: string;
            export declare const DivisionSuperiorN2Codigo: string;
            export declare const DivisionSuperiorN2Nombre: string;
            export declare const DivisionSuperiorN2DivisionSuperiorN1: string;
        }

        ['Id', 'Codigo', 'Nombre', 'DivisionSuperiorN2', 'DivisionSuperiorN2Codigo', 'DivisionSuperiorN2Nombre', 'DivisionSuperiorN2DivisionSuperiorN1'].forEach(x => (<any>Fields)[x] = x);
    }
}

