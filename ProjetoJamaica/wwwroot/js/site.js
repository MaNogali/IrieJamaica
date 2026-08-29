function validarSenhas() {
    const senha = document.getElementById("senha").value;
    const confirmar = document.getElementById("confirmarSenha").value;

    if (senha !== confirmar) {
        alert("As senhas não coincidem.");
        return false;
    }

    return true;
}