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
            {{ isAddMode ? 'Ok' : 'Agregar' }}
        </button>
        <PermissionList />
        <h1>Hello World</h1>
    </div>
</template>

<script>
export default {
    data() {
        return store;
    }
}
</script>