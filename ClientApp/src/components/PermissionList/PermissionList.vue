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
                </tr>
            </thead>
            <tbody>
                <NewPermissionItem v-if="isAddMode" />
                <tr>
                    <td>Ulises</td>
                    <td>Ulises</td>
                    <td>Ulises</td>
                    <td>Ulises</td>
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