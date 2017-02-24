namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasN5Row {
        Id?: number;
        Codigo?: string;
        Nombre?: string;
        DivisionSuperiorN4?: number;
        DivisionSuperiorN4Codigo?: string;
        DivisionSuperiorN4Nombre?: string;
        DivisionSuperiorN4DivisionSuperiorN3?: number;
    }

    export namespace GenDivisionesAdministrativasN5Row {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenDivisionesAdministrativasN5';
        export const lookupKey = 'General.DivisionesAdministrativasN5';

        export function getLookup(): Q.Lookup<GenDivisionesAdministrativasN5Row> {
            return Q.getLookup<GenDivisionesAdministrativasN5Row>('General.DivisionesAdministrativasN5');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Codigo: string;
            export declare const Nombre: string;
            export declare const DivisionSuperiorN4: string;
            export declare const DivisionSuperiorN4Codigo: string;
            export declare const DivisionSuperiorN4Nombre: string;
            export declare const DivisionSuperiorN4DivisionSuperiorN3: string;
        }

        ['Id', 'Codigo', 'Nombre', 'DivisionSuperiorN4', 'DivisionSuperiorN4Codigo', 'DivisionSuperiorN4Nombre', 'DivisionSuperiorN4DivisionSuperiorN3'].forEach(x => (<any>Fields)[x] = x);
    }
}

