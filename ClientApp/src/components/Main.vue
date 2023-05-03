<script setup>
    import { store } from '../store';
    import Header from './Header/Header.vue';
    import PermissionList from './PermissionList/PermissionList.vue';
</script>
<template>
    <Header />
    <div class="container">
        <br />
        <button class="btn btn-primary" @click="store.changeAddMode()">
            {{ isAddMode ? 'Cancelar' : 'Agregar' }}
        </button>
        <PermissionList />
    </div>
</template>

<script>
export default {
    mounted() {
        store.fetchPermissions();
        store.fetchPermissionTypes();
    },
    data() {
        return store;
    }
}
</script>