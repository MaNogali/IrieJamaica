function validarSenhas() {
    const nome = document.getElementById("nome").value;
    const email = document.getElementById("email").value;

    const senha = document.getElementById("senha").value;
    const confirmar = document.getElementById("confirmarSenha").value;

    if (nome == null) {
        alert("Digite um nome")
        return false;

    }
    if (email == null) {
        alert("Digite um email")
        return false;
    }
    if (senha !== confirmar) {
        alert("As senhas não coincidem.");
        return false;
    }

    return true;
}