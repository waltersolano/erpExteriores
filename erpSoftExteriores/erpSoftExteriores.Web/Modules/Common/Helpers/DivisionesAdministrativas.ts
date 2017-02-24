namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerClass()
    export class divisionesAdministrativas {
            
        public ad1: Serenity.LookupEditor;
        public ad2: Serenity.LookupEditor;
        public ad3: Serenity.LookupEditor;
        public ad4: Serenity.LookupEditor;
        public ad5: Serenity.LookupEditor;


        public addFilterEvents(gridObj: any, filterFields: any) {
            try { this.ad1 = gridObj.findQuickFilter(Serenity.LookupEditor, filterFields[0]) } catch (e) { }
            try { this.ad2 = gridObj.findQuickFilter(Serenity.LookupEditor, filterFields[1]); this.ad2.clearItems(); } catch (e) { }
            try { this.ad3 = gridObj.findQuickFilter(Serenity.LookupEditor, filterFields[2]); this.ad3.clearItems(); } catch (e) { }
            try { this.ad4 = gridObj.findQuickFilter(Serenity.LookupEditor, filterFields[3]); this.ad4.clearItems(); } catch (e) { }
            try { this.ad5 = gridObj.findQuickFilter(Serenity.LookupEditor, filterFields[4]); this.ad5.clearItems(); } catch (e) { }
            this.ad1.changeSelect2(e => { this.divisionSuperiorChangeBehavior(this.ad1, this.ad2, "General.DivisionesAdministrativasN2", "DivisionSuperiorN1"); });
            this.ad2.changeSelect2(e => { this.divisionSuperiorChangeBehavior(this.ad2, this.ad3, "General.DivisionesAdministrativasN3", "DivisionSuperiorN2"); });
            this.ad3.changeSelect2(e => { this.divisionSuperiorChangeBehavior(this.ad3, this.ad4, "General.DivisionesAdministrativasN4", "DivisionSuperiorN3"); });
            this.ad3.changeSelect2(e => { this.divisionSuperiorChangeBehavior(this.ad4, this.ad5, "General.DivisionesAdministrativasN5", "DivisionSuperiorN4"); });
        }

        public divisionSuperiorChangeBehavior(adA: Serenity.LookupEditor, adB: Serenity.LookupEditor, keyLookup: string, filterField: string) {
            switch (filterField) {
                case "DivisionSuperiorN1":
                    try {
                        this.ad2.clearItems();
                        this.ad2.value = "";
                        this.ad3.clearItems();
                        this.ad3.value = "";
                        this.ad4.clearItems();
                        this.ad4.value = "";
                        this.ad5.clearItems();
                        this.ad5.value = "";
                    } catch (e) { }
                    break;
                case "DivisionSuperiorN2":
                    try {
                        this.ad3.clearItems();
                        this.ad3.value = "";
                        this.ad4.clearItems();
                        this.ad4.value = "";
                        this.ad5.clearItems();
                        this.ad5.value = "";
                    }
                    catch (e) { }
                    break;
                case "DivisionSuperiorN3":
                    try {
                        this.ad4.clearItems();
                        this.ad4.value = "";
                        this.ad5.clearItems();
                        this.ad5.value = "";
                    }
                    catch (e) { }
                    break;
                case "DivisionSuperiorN4":
                    try {
                        this.ad5.clearItems();
                        this.ad5.value = "";
                    }
                    catch (e) { }
                    break;
            }
            try {
                let val = adA.value;
                let adBFilteredItems = val ? Q.getLookup(keyLookup).items.filter(x => x[filterField] == parseInt(val)) : [];
                for (let item of adBFilteredItems) {
                    adB.addItem({
                        id: item["Id"],
                        text: item["Nombre"],
                        disabled: false,
                        source: item,
                    });
                }

            }
            catch (e) { }
        }



    }
}