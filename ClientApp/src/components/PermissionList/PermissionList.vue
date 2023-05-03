<script setup>
import { store } from '../../store';
import NewPermissionItem from '../NewPermissionItem/NewPermissionItem.vue';

</script>
<template>
    <div class="container">
        <table class="table">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Tipo Permiso</th>
                    <th>Fecha</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <NewPermissionItem v-if="isAddMode" />
                <tr v-for="item in permissions">
                    <td class="col-md-2" v-if="item.id !== store.itemEditing">{{ item.name }}</td>
                    <td class="col-md-2" v-if="item.id === store.itemEditing"><input class="form-control" v-model="item.name"/></td>
                    <td class="col-md-2" v-if="item.id !== store.itemEditing">{{ item.lastName }}</td>
                    <td class="col-md-2" v-if="item.id === store.itemEditing"><input class="form-control" v-model="item.lastName"/></td>
                    <td class="col-md-2" v-if="item.id !== store.itemEditing">{{ item.userPermission.description }}</td>
                    <td class="col-md-2" v-if="item.id === store.itemEditing">
                        <select :class="true ? 'form-control' : 'form-control is-invalid'" v-model="item.userPermission">
                            <option v-for="type in store.permissionTypes" :value="type">
                                {{type.description}}
                            </option>
                        </select>
                    </td>
                    
                    <td class="col-md-2" v-if="item.id !== store.itemEditing">{{ item.date }}</td>
                    <td class="col-md-2" v-if="item.id === store.itemEditing"><input style="height: 38px" type="date" class="form-control" v-model="item.date"/></td>
                    <td class="col-md-2">
                        <button 
                            class="btn btn-outline-warning btn-sm" 
                            @click="itemEditing !== item.id ? store.changeItemEditing(item.id) : store.updatePermission(item)">
                                {{ itemEditing === item.id ? 'OK' : 'Editar'}}
                        </button>
                        <button 
                            class="btn btn-outline-danger btn-sm" 
                            @click="confirm() ? store.deletePermission(item) : null">Borrar
                        </button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>
<script>
export default {
    methods: {
        confirm() {
            return window.confirm("Esta seguro que deseas borrar el permiso ?")
        }
    },
    data() {
        return store;
    }
}
</script>