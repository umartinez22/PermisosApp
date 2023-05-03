<script setup>
    import { store } from '../../store';
</script>

<template>
    <tr>
        <td><input :class="isNameValid ? 'form-control' : 'form-control is-invalid'" v-model="store.newPermission.name"/></td>
        <td><input :class="isLastNameValid ? 'form-control' : 'form-control is-invalid'" v-model="store.newPermission.lastName" /></td>
        <td>
            <select :class="isTypeValid ? 'form-control' : 'form-control is-invalid'" v-model="store.newPermission.userPermission">
                <option v-for="type in store.permissionTypes" :value="type">
                    {{type.description}}
                </option>
            </select>
        </td>
        <td><input type="date" :class="isDateValid ? 'form-control' : 'form-control is-invalid'" v-model="store.newPermission.date" /></td>
        <td>
            <button 
                :disabled="!isNameValid || !isLastNameValid || !isTypeValid || !isDateValid" 
                class="btn btn-primary" 
                @click="store.savePermission()" >Ok
            </button>
        </td>
    </tr>
</template>
<script>
export default {
    computed: {
        isNameValid() {
            return store.newPermission.name !== undefined && 
                store.newPermission.name !== '';
        },
        isLastNameValid() {
            return store.newPermission.lastName !== undefined && 
                store.newPermission.lastName !== '';
        },
        isTypeValid() {
            return store.newPermission.userPermission != undefined;
        },
        isDateValid() {
            return store.newPermission.date &&
                store.newPermission.date !== '';
        }
    },
    methods: {
        sayHello() { console.log('hello')}
    }
}
</script>