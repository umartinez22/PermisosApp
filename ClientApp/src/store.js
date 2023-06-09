import { reactive } from 'vue'

export const store = reactive({
    isAddMode: false,
    changeAddMode() {
        this.isAddMode = !this.isAddMode;
    },
    itemEditing: 0,
    changeItemEditing(id) {
        this.itemEditing = id;
    },
    permissionTypes: [],
    async fetchPermissionTypes() {
        let response = await fetch('/PermissionType');
        let values = await response.json();
        this.permissionTypes = values;
    },
    newPermission: {},
    permissions: [],
    async fetchPermissions() {
        let response = await fetch('/Permission');
        let values = await response.json();
        this.permissions = values.reverse();
    },
    async savePermission() {
        await fetch('/Permission', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }, body: JSON.stringify({ ...this.newPermission })
        });
        await this.fetchPermissions();

        this.isAddMode = false;
        this.newPermission = {};
    },
    async deletePermission(permission) {
        await fetch('/Permission', {
            method: 'Delete',
            headers: {
                'Content-Type': 'application/json'
            }, body: JSON.stringify({ ...permission })
        });
        await this.fetchPermissions();
    },
    async updatePermission(permission) {
        await fetch('/Permission', {
            method: 'Put',
            headers: {
                'Content-Type': 'application/json'
            }, body: JSON.stringify({ ...permission })
        });
        await this.fetchPermissions();
        this.itemEditing = 0;
    }
})