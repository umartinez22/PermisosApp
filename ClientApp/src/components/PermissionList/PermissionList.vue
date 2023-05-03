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
                    <td>{{ item.name }}</td>
                    <td>{{ item.lastName }}</td>
                    <td>{{ item.userPermission.description }}</td>
                    <td>{{ item.date }}</td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>
<script>
export default {
    data() {
        return store;
    }
}
</script>