import { reactive } from 'vue'

export const store = reactive({
    isAddMode: false,
    changeAddMode() {
        this.isAddMode = !this.isAddMode;
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
        this.permissions = values;
    },
    async savePermission() {
        console.log(this.newPermission.userPermission)
        await fetch('/Permission', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }, body: JSON.stringify({ ...this.newPermission })
        });

        try {
            await this.fetchPermissions();
        } finally {
            this.isAddMode = false;
            this.newPermission = {}
        }
    }
})